import { Component, OnInit } from '@angular/core';
import { AppService } from '../../app.service';
import { ChatService } from '../chat.service';

@Component({
  selector: 'app-Lista-Grupos',
  templateUrl: './Lista-Grupos.component.html',
  styleUrls: ['./Lista-Grupos.component.scss']
})
export class ListaGruposComponent implements OnInit {

  listaG: any[] = []
 constructor( private _chatservice: ChatService ) {

}

  ngOnInit(): void {
  this.getgrupoLista();

  }

  getgrupoLista(){
    this._chatservice.getListagrupo().subscribe(res => {
          this.listaG = res as any[]
    })
  }





}
