<?php

class BlackHeadDuck extends Duck
{
	public $title;
	public function __construct()
	{
		$this->title = "Утка с чёрной головой";
		$this->img = "BlackHeadDuck.jpg";
		$this->id = "BlackHeadDuck";
		$this->setFly(new FlyWithWings());
		$this->setQuack(new LowQuack());
	}
}


?>