import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBrand } from '../models/brand';
import { IPagination } from '../models/pagination';
import { IType } from '../models/productType';
import {map} from 'rxjs/operators';
import { ShopParams } from '../models/shopParams';
import { IProduct } from '../models/product';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = "https://localhost:44300/api/"

  constructor(private http: HttpClient) { }

  getProducts(shopParams:ShopParams){
    let params = new HttpParams();

    if(shopParams.brandId !== 0){
      params = params.append('brandId',shopParams.brandId.toString());
    }

    if(shopParams.typeId !== 0){
      params = params.append('typeId',shopParams.typeId.toString());
    }

      params = params.append('Sort',shopParams.sort);
      params = params.append('PageIndex', shopParams.pageNumber.toString());
      params = params.append('PageSize', shopParams.pageSize.toString());

      if(shopParams.search){
        params = params.append('search',shopParams.search);
      }

    return this.http.get<IPagination>(this.baseUrl+'products', {observe:'response', params})
    .pipe(
      map(response => {
        return response.body;
      })
    );
  }

  getProduct(id:number){
    return this.http.get<IProduct>(this.baseUrl+'products/'+id);
  }

  getBrands(){
    return this.http.get<IBrand[]>(this.baseUrl+'products/brands');
  }

  getTypes(){
    return this.http.get<IType[]>(this.baseUrl+'products/types');
  }

}
