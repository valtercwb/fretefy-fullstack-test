import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Regiao } from '../model/regiao.model';

const baseUrl = 'http://localhost:5000/api/regiao';

@Injectable({
  providedIn: 'root'
})

export class RegiaoService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Regiao> {
    return this.http.get<Regiao>(baseUrl);
  }

  get(id): Observable<any> {
    return this.http.get(`${baseUrl}/${id}`);
  }

  create(data): Observable<any> {
    return this.http.post(baseUrl, data);
  }

  update(id, data): Observable<any> {
    return this.http.put(`${baseUrl}/${id}`, data);
  }

}