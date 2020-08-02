import { Injectable } from '@angular/core';
import { HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HttpService } from '../api/http.service';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root',
})
export class GenericApiService {
  private apiController: string;

  constructor(private api: HttpService) {
  }

  setController(name: string) {
    this.apiController = name;
  }
  public getAll(): Observable<any[]> {
      return this.api.get(`${this.apiController}`);
  }

  public get(id: number): Observable<any> {
      return this.api.get(`${this.apiController}/${id}`);
  }

  public delete(id: number): Observable<boolean> {
      return this.api.delete(`${this.apiController}/${id}`);
  }

  public add(item: any): Observable<any> {
      return this.api.post(this.apiController, item);
  }

  public update(item: any): Observable<any> {
      return this.api.put(`${this.apiController}/${item['id']}`, item);
  }
}
