import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from 'src/shared/layout/layout.component';
import { ListaGruposComponent } from './chat/Lista-Grupos/Lista-Grupos.component';
import { ChatComponent } from './chat/chat.component';

const routes: Routes = [
  {
    path:'',
    component: LayoutComponent,
    children: [
      {
        path:'listaGrupo',
        component: ListaGruposComponent
      },
      {
        path:'Chat/:grupo/:id',
        component: ChatComponent
      }
    ]
  },



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
