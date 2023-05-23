import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core'
import { RouterModule } from '@angular/router';
import { ListaGruposComponent } from './Lista-Grupos/Lista-Grupos.component';
import { ChatComponent } from './chat.component';
import { ReactiveFormsModule } from '@angular/forms';




@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild([]),
    ReactiveFormsModule
  ],
  declarations:[
    ListaGruposComponent,
    ChatComponent
  ],
})

export class ChatModule{ }
