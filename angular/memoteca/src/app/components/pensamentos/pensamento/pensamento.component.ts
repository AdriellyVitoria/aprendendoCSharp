import { Pensamento } from './../../../core/types/pensamento';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-pensamento',
  templateUrl: './pensamento.component.html',
  styleUrls: ['./pensamento.component.css']
})
export class PensamentoComponent {

  @Input()
  pensamento: Pensamento = {
    conteudo: 'I love Angular',
    autoria: 'Adriee',
    modelo: "modelo3",
    id: '3'
  }

  larguraPensamento(): string {
    if(this.pensamento.conteudo.length >= 256) {
      return 'pensamento-g'
    } 
    return 'pensamento-p'
  }
}
