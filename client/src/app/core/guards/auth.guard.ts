import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import {AccountService} from '../../account/account.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private accountService: AccountService, private router: Router) {}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> {
    return this.accountService.currentUser$.pipe(
      map(auth => {
        if (auth) {
          return true;
        }
        this.router.navigate(['account/login'], {queryParams: {returnUrl: state.url}})
      })
    )
  }
}
