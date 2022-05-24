import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Country } from './model/country';
import { CountrysService } from './services/countrys.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'SaveAlife';
  countrys: Observable<Country[]>;
  displayedColumns = ['country', 'cases', 'confirmed', 'deaths', 'recovered', 'update_at'];
  
  constructor(private countryService: CountrysService) {
    this.countrys = this.countryService.list(); 
  }
  
  ngOnInit(): void {
  }
}
