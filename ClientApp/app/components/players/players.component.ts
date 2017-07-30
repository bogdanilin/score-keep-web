import { Component, OnInit } from '@angular/core';
import { Player } from '../../models/player';

@Component({
    selector: 'sk-players',
    templateUrl: './players.component.html'
})
export class PlayersComponent implements OnInit {
    ngOnInit(): void {
        this.players = [
            new Player(1, "Bogdan", "Ilin"),
            new Player(2, "Donald", "Nairn"),
            new Player(3, "Lee", "Cockerill"),
            new Player(4, "Eric", "Rousset"),
            new Player(5, "Chris", "Warner"),
            new Player(6, "Fraser", "Stewart"),
            new Player(7, "Ross", "Macdonald"),
            new Player(8, "Basil", "Khan"),
            new Player(9, "Calum", "Johnson")
        ]
    }

    players: Player[];


}
