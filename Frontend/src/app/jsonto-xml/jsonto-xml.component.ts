import { Component, OnInit } from '@angular/core';
import { JsonService } from '../shared/json.service';

@Component({
  selector: 'app-jsonto-xml',
  templateUrl: './jsonto-xml.component.html',
  styleUrls: ['./jsonto-xml.component.css']
})
export class JSONtoXMLComponent implements OnInit {

  jsonService! : JsonService;

  ngOnInit(): void {
    
  }
}
