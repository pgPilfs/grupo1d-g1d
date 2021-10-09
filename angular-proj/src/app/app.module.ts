import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';



import { AppComponent } from './app.component';
import { LayoutModule } from './layout/layout.module';
import { AppRoutingModule } from './app-routing.module';
import { PagesModule } from './pages/pages.module';
import { OperatoriaPesosModule } from './operatoria-pesos/operatoria-pesos.module';
import { CommonModule, DatePipe } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ParticlesModule } from 'angular-particle';
import { CuentaService } from '../Servicios/cuenta.service';
import { ClienteService } from '../servicios/cliente.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthService } from '../app/Servicios/auth.service';
import { JwtInterceptor } from '../app/Servicios/interceptor.service';
import { ErrorInterceptor } from '../app/Servicios/error.service';
import { ReactiveFormsModule, FormsModule } from '@angular/forms'
import { RouterModule } from '@angular/router';
import {  CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';


@NgModule({
  declarations: [
    AppComponent,

  ],
  imports: [
    BrowserModule,
    CommonModule,
    LayoutModule,
    PagesModule,
    OperatoriaPesosModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ParticlesModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule
   // DatePipe
],
  providers: [ClienteService, AuthService, 
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
  ],
  bootstrap: [AppComponent],
  schemas: [NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA]
  
})
export class AppModule { }
