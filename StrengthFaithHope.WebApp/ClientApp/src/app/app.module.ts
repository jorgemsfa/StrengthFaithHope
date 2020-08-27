
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { MessageListComponent } from './components/message-list/message-list.component';
import { MessageService } from './services/message.service';
import { MatCardModule } from '@angular/material/card';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MessageCreateComponent } from './components/message-create/message-create.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    MessageListComponent,
    MessageCreateComponent

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserModule,
    RouterModule.forRoot([
      { path: '', component: MessageListComponent, pathMatch: 'full' },
      { path: 'message', component: MessageCreateComponent, pathMatch: 'full' }
    ]),
    MatCardModule,
    BrowserAnimationsModule,
  ],
  providers: [MessageService],
  bootstrap: [AppComponent],

})
export class AppModule { }
