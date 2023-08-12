import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CalculadoraService {
  private apiUrl = 'http://localhost:port/api/calculator/';

  constructor(private http: HttpClient) { }

  calcular(expression: string) {
    return this.http.get<number>(`${this.apiUrl}calcular?expression=${expression}`);
  }
}
