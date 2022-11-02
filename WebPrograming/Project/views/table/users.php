<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use app\models\Users;


$this->title = 'Учасники';
$users = Users::find()->orderBy('id')->all();
?>
<div class="site-index">
<h1>Учасники</h1>
<table class="table table-striped">
    <th>#</th>
    <th>Имя</th>
    <th>Фамилия</th>
    <th>Логин</th>
    <th>Пароль</th>
    
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
    <td>
        <?= $user->username ?>
    </td>
    <td>
        <?= $user->password ?>
    </td>
    </tr>
<?php endforeach; ?>

</table>
    

    
</div>
