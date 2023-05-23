import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ChatService } from './chat.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {

  nombregrupo!: string | null
  groupID!: number
  chatForm!: FormGroup;

  constructor( private _routes: ActivatedRoute,
               private _chatservice: ChatService,
               private _formB: FormBuilder) {
        this.nombregrupo = this._routes.snapshot.paramMap.get("grupo");
        this.groupID = Number(this._routes.snapshot.paramMap.get('id'));
   }

  ngOnInit() {
    this.getform();
  }


getform() {
  this.chatForm = this._formB.group({
      sala: ['', Validators.required],
      usuario: ['', Validators.required],
      mensaje: ['', Validators.required]
  })
}


  setMensaje(){


    let param = {
      sala: this.groupID,
      user: this.chatForm.value.usuario,
      mensaje: this.chatForm.value.mensaje
    }
      this._chatservice.setMensajeEnviar(param).subscribe(res => {

      })
  }




}
