import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { APIURL } from 'src/shared/APIURL';

@Injectable({
  providedIn: 'root'
})
export class ChatService {

constructor( private _http: HttpClient) { }



getListagrupo(){
  return this._http.get(APIURL.chat.listaGrupo);
}


setMensajeEnviar(params: any){
  debugger
  let arg = "sala=" + params.sala +
              "&user=" + params.user +
              "&mensaje=" + params.mensaje
                //const headerOptions = new HttpHeaders({'Content-Type':'application/json'});
  return this._http.post(APIURL.chat.enviarmensaje, arg)
}


}
