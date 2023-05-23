import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { LayoutComponent } from 'src/shared/layout/layout.component';
import { ChatModule } from './chat/chat.module';

@NgModule({
  declarations: [
    AppComponent,
      LayoutComponent,

   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ChatModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
