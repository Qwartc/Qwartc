<?php

class Duck
{

	private $flyBehavior;
	private $quackBehavior;

	public function setFly( $flyBehavior )
	{
		$this->flyBehavior = $flyBehavior;
	}
	public function fly()
	{
		$this->flyBehavior->fly();
	}
	public function setQuack( $quackBehavior )
	{
		$this->quackBehavior = $quackBehavior;
	}
	public function quack()
	{
		$this->quackBehavior->quack();
	}
}

?>