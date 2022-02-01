import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cidade } from '../model/cidade.model';

const baseUrl = 'http://localhost:5000/api/cidade';

@Injectable({
  providedIn: 'root'
})

export class CidadeService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Cidade> {
    return this.http.get<Cidade>(baseUrl);
  }
}