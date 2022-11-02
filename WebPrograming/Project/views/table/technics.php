<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use app\models\Technics;


$this->title = 'Техника';
$users = Technics::find()->orderBy('id')->all();
?>
<div class="site-index">
<h1>Техника</h1>
<table class="table table-striped">
    <th>#</th>
    <th>Название</th>
    <th>База</th>
    <th>Гос номер</th>
    <th>Расход топлива</th>
    <th>Водитель</th>
<?php foreach ($users as $user): ?>
    <tr>
    <td>
        <?= $user->id ?>
    </td>
    <td>
        <?= $user->name ?>
    </td>
    <td>
        <?= $user->base ?>
    </td>
    <td>
        <?= $user->state_number ?>
    </td>
        <td>
        <?= $user->fuel_сonsumption ?>
    </td>
    <td>
        <?= $user->driver ?>
    </td>
    </tr>
<?php endforeach; ?>

</table>
    

    
</div>