<?php

namespace App\Livewire;
// check dit voor ieder volgend bestand

use Livewire\Component;

class CreatePoll extends Component
{
    public $title;

    public function render()
    {
        return view('livewire.create-poll');
    }
}