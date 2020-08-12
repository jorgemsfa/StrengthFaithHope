import { Component, OnInit } from '@angular/core';
import { MessageService } from '../../services/message.service';
import { Message } from 'src/app/models/message.model';

@Component({
  selector: 'app-home',
  templateUrl: './message-list.component.html',
  styleUrls: ['./message-list.component.css']
})
export class MessageListComponent implements OnInit {

  messages:Message[];

  constructor(private messageService: MessageService) { }

  ngOnInit() {
    this.list();
  }

  list() {

    this.messageService.get()
      .subscribe(
        result => {
          this.messages = result;
        },
        err => {
          console.log(err);
        }

    ) }

}
