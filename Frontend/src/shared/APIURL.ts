
import { environment } from '../environments/environment.development'


let BASEURL = environment.Api;


export let APIURL = {

chat: {
  listaGrupo: BASEURL + 'api/Acceso/grupolist',
  enviarmensaje: BASEURL + 'api/Acceso/Chat?',
  AddGroup: BASEURL + ''
}

}
