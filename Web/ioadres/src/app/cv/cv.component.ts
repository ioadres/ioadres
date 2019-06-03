import { Component } from '@angular/core';

const AssetPath = '/assets/'
@Component({
  selector: 'cv',
  templateUrl: './cv.component.html',
  styleUrls: ['./cv.component.scss']
})
export class CvComponent  {
  TechsRow1 : string[] = [`${AssetPath}angular.png`,`${AssetPath}vue.png`,`${AssetPath}netcore.jpg`,`${AssetPath}netframework.png`,`${AssetPath}xamarin.png`];
  TechsRow2 : string[] = [`${AssetPath}git.png`,`${AssetPath}tfs.png`,`${AssetPath}c.png`,`${AssetPath}js.png`,`${AssetPath}sass.png`];
  TechsRow3 : string[] = [`${AssetPath}mysql.jpg`,`${AssetPath}sqls.png`];
}
