<?php

class RedHeadDuck extends Duck
{
	public $title;
	public $img;
	public $id;
	public function __construct()
	{
		$this->title = "Утка с красной головой";
		$this->img = "RedHeadDuck.png";
		$this->id = "RedHeadDuck";
		$this->setFly(new FlyWithoutWings());
		$this->setQuack(new HighQuack());
	}
}


?>