﻿using UnityEngine;
using UnityEngine.UI;

namespace subjectnerdagreement.psdexport
{
    public class NInputFieldBinder : ABinder
    {
#if NGUI
        public override void StartBinding(GameObject mainObj, string args, string layerName)
        {
            UISprite bgTrans = LayerWordBinder.findChildComponent<UISprite>(mainObj, "background");
            bgTrans.type = UIBasicSprite.Type.Sliced;

            UILabel text = LayerWordBinder.findChildComponent<UILabel>(mainObj, "holder");
            text.transform.localPosition -= bgTrans.transform.localPosition;
            text.pivot = UIWidget.Pivot.Left ;
             
            LayerWordBinder.NGUICopySprite(bgTrans.gameObject , mainObj , true);
            NGUITools.AddWidgetCollider(mainObj);

            UIInput inputField = LayerWordBinder.swapComponent<UIInput>(mainObj);
            inputField.label = text;
        }
#endif
    }
}