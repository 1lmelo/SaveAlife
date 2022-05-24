import { Injectable } from '@angular/core';
import { Country } from '../model/country';
import { HttpClient } from '@angular/common/http'
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class CountrysService {

  private readonly API = 'https://localhost:44367/api/Covid/GetDataCovid';

  constructor(private httpclient: HttpClient) { }

  list() {
    return this.httpclient.get<Country[]>(this.API)
    .pipe(
      tap(countrys => console.log(countrys))
    );
  }
}
