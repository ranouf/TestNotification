import { Component, OnInit } from '@angular/core';
import { NotificationClient } from './services/api.services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';

  constructor(
    public notificationClient: NotificationClient) {

  }

  ngOnInit(): void {
    this.notificationClient.getAll(1).subscribe(result => {
      debugger;
      console.log(result)
    });
  }
}
