<?php

/* @var $this \yii\web\View */
/* @var $content string */

use app\widgets\Alert;
use yii\helpers\Html;
use yii\bootstrap\Nav;
use yii\bootstrap\NavBar;
use yii\widgets\Breadcrumbs;
use app\assets\AppAsset;
use app\models\Users;

AppAsset::register($this);

?>
<?php $this->beginPage() ?>
<!DOCTYPE html>
<html lang="<?= Yii::$app->language ?>">
<head>
    <meta charset="<?= Yii::$app->charset ?>">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <?php $this->registerCsrfMetaTags() ?>
    <title><?= Html::encode($this->title) ?></title>
    <?php $this->head() ?>
</head>
<body>
<?php $this->beginBody() ?>

<div class="wrap">
    <?php
    if (Yii::$app->user->isGuest || Yii::$app->user->identity->accessToken == 2)
    {
    NavBar::begin([
        'brandLabel' => "COMPANY",
        'brandUrl' => Yii::$app->homeUrl,
        'options' => [
            'class' => 'navbar-inverse navbar-fixed-top',
        ],
    ]);
    }
    else
    {
        NavBar::begin([

        'options' => [
            'class' => 'navbar-inverse navbar-fixed-top',
        ],
    ]);
    }
    if (Yii::$app->user->isGuest || Yii::$app->user->identity->accessToken == 2)
    {
    echo Nav::widget([
        'options' => ['class' => 'navbar-nav navbar-right'],
        'items' => [
            ['label' => 'Home', 'url' => ['/site/index']],
            //['label' => 'Базы', 'url' => ['/table/bases']],
            //['label' => 'Техника', 'url' => ['/table/technics']],
            //['label' => 'Поля', 'url' => ['/table/fields']],
            ['label' => 'Сделаные поля', 'url' => ['/table/fields_done']],
            ['label' => 'События', 'url' => ['/table/action']],
            //['label' => 'Химия', 'url' => ['/table/chemicals']],
            ['label' => 'Топливо', 'url' => ['/table/fuel']],
            ['label' => 'Топливо на базе', 'url' => ['/table/fuel_on_base']],
            //['label' => 'Работники', 'url' => ['/table/workers']],
            //['label' => 'Тип', 'url' => ['/table/type']],
            Yii::$app->user->isGuest ? (
                ['label' => 'Login', 'url' => ['/site/login']]
            ) : (
                '<li>'
                . Html::beginForm(['/site/logout'], 'post')
                .'<label style="color:white;">'.Yii::$app->user->identity->name .' '. Yii::$app->user->identity->surname.'</label>'
                . Html::submitButton(
                     ' Выйти' ,
                    ['class' => 'btn btn-link logout']
                )
                . Html::endForm()
                . '</li>'
            )
        ],
    ]);
    }
    else
    {
         echo Nav::widget([
        'options' => ['class' => 'navbar-nav navbar-right'],
        'items' => [
            ['label' => 'Учасники', 'url' => ['/table/users'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Базы', 'url' => ['/table/bases'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Техника', 'url' => ['/table/technics'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Поля', 'url' => ['/table/fields'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Сделаные поля', 'url' => ['/table/fields_done'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'События', 'url' => ['/table/action'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Химия', 'url' => ['/table/chemicals'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Топливо', 'url' => ['/table/fuel'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Топливо на базе', 'url' => ['/table/fuel_on_base'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Работники', 'url' => ['/table/workers'],'options' => ['style' => 'font-size: 13px;']],
            ['label' => 'Тип', 'url' => ['/table/type'],'options' => ['style' => 'font-size: 13px;']],
            Yii::$app->user->isGuest ? (
                ['label' => 'Login', 'url' => ['/site/login']]
            ) : (
                '<li>'
                . Html::beginForm(['/site/logout'], 'post')
                .'<label style="color:white;">'.Yii::$app->user->identity->name .' '. Yii::$app->user->identity->surname.'</label>'
                . Html::submitButton(
                     ' Выйти' ,
                    ['class' => 'btn btn-link logout']
                )
                . Html::endForm()
                . '</li>'
            )
        ],
    ]);
    }
    NavBar::end();
    ?>

    <div class="container">
        <?= Breadcrumbs::widget([
            'links' => isset($this->params['breadcrumbs']) ? $this->params['breadcrumbs'] : [],
        ]) ?>
        <?= Alert::widget() ?>
        <?= $content ?>
    </div>
</div>

<footer class="footer">
    <div class="container">
        <p class="pull-left">&copy;By Alex <?= date('Y') ?></p>

        <!--<p class="pull-right"><?= Yii::powered() ?></p>-->
    </div>
</footer>

<?php $this->endBody() ?>
</body>
</html>
<?php $this->endPage() ?>
