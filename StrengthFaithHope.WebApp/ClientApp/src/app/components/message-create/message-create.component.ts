import { Component, OnInit } from '@angular/core';
import { MessageService } from '../../services/message.service';
import { Message } from 'src/app/models/message.model';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Type } from 'src/app/models/type.model';

@Component({
  selector: 'app-home',
  templateUrl: './message-create.component.html',
})

export class MessageCreateComponent implements OnInit {

  form: FormGroup;


  constructor(
    private messageService: MessageService,
    public formBuilder:FormBuilder
    ) { }

  ngOnInit() {

    this.form = this.formBuilder.group({
      sentence:[''],
      title:[''],

    })



  }
  onSubmit()
  {
    const dados: Message = this.form.value;
    console.log(dados);
  }


}
