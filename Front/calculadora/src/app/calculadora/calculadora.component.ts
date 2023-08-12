import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CalculadoraService } from './calculadora.service';

@Component({
  selector: 'app-calculadora',
  templateUrl: './calculadora.component.html',
  styleUrls: ['./calculadora.component.css']
})
export class CalculadoraComponent implements OnInit {
  currentValue = '';

  constructor(private calculadoraService: CalculadoraService) { }

  ngOnInit(): void {
  }

  operador(op: string) {
    this.currentValue += op;
  }

  numero(num: number) {
    this.currentValue += num;
  }

  limpar() {
    this.currentValue = '';
  }

  resultado() {
    const result = this.calculadoraService.calcular(this.currentValue)
      .subscribe(data => {
        this.currentValue = data.toString();
      });
  }
}
