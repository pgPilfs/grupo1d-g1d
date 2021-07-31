import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header/header.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FooterComponent } from './footer/footer.component';
import { AppRoutingModule } from '../app-routing.module';

import { SidebarModule } from 'ng-sidebar';

import { SidebarComponent } from './sidebar/sidebar.component';

@NgModule({
  declarations: [
    HeaderComponent,
    NavbarComponent,
    FooterComponent,
    SidebarComponent,
    
  ],
  imports: [
    CommonModule, 
    AppRoutingModule,
    SidebarModule.forRoot()
    ],
  exports: [HeaderComponent, NavbarComponent, FooterComponent, SidebarComponent],
})

export class LayoutModule { }
