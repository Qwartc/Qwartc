<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use app\models\Workers;


$this->title = 'Работники';
$users = Workers::find()->orderBy('id')->all();
?>
<div class="site-index">
<h1>Работники</h1>
<table class="table table-striped">
    <th>#</th>
    <th>Имя</th>
    <th>Фамилия</th>
<?php foreach ($users as $user): ?>
    <tr>
    <td>
        <?= $user->id ?>
    </td>
    <td>
        <?= $user->name ?>
    </td>
    <td>
        <?= $user->surname ?>
    </td>
    </tr>
<?php endforeach; ?>

</table>
    

    
</div>
