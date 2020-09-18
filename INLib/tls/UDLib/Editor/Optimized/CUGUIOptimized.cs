using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

namespace UDLib.Editor
{
    public class CUGUIOptimized
    {        
        /// <summary>
        /// Containerһ��Ϊ�ϴ�������ڡ�
        /// </summary>
        /// <param name="menuCommand"></param>
        [MenuItem("GameObject/UI����/����/Container", priority = 13)]
        static public GameObject CreatContainerByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatPanel(menuCommand,"Container");
        }

        [MenuItem("GameObject/UI����/����/FullScreenPanel", priority = 13)]
        static public GameObject CreatPanelByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatPanel(menuCommand,"Panel");
        }

        /// <summary>
        /// ȫ��panel���棬����ͼĬ��ʹ��ԭ�ߴ�,��͸����
        /// </summary>
        /// <param name="menuCommand"></param>
        /// <param name="suffixName"></param>
        /// <returns></returns>
        //[MenuItem("UI����/����/FullScreenPanel", false)]
        static public GameObject CreatPanel(MenuCommand menuCommand, string suffixName)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Panel");
            GameObject panelGo = Selection.activeGameObject;
            panelGo.name = "Xxx" + suffixName;
            GameObjectUtility.SetParentAndAlign(panelGo, menuCommand.context as GameObject);
            Image imageComp = panelGo.GetComponent<Image>();
            GameObject.DestroyImmediate(imageComp);

            // �����������ڵ�
            GameObject bgGo = new GameObject("con_bg",typeof(RectTransform));
            RectTransform rectTransform = bgGo.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(0,0);
            rectTransform.anchorMin = new Vector2(0,0);
            rectTransform.anchorMax = new Vector2(1,1);
            GameObjectUtility.SetParentAndAlign(bgGo, panelGo);

            // ����ͼ
            GameObject bgImg = new GameObject("img_bg", typeof(Image));
            bgImg.GetComponent<Image>().raycastTarget = false;
            RectTransform bgGoTransform = bgImg.GetComponent<RectTransform>();
            bgGoTransform.sizeDelta = new Vector2(1334,750);
            Image ImgBgComp = bgImg.GetComponent<Image>();
            ImgBgComp.color = new Color32(255, 255, 255, 100);
            GameObjectUtility.SetParentAndAlign(bgImg, bgGo);

            // ������⸸�ڵ�
            GameObject titleGo = new GameObject("con_title", typeof(Image));
            titleGo.GetComponent<Image>().raycastTarget = false;
            RectTransform titleGoTransform = titleGo.GetComponent<RectTransform>();
            GameObjectUtility.SetParentAndAlign(titleGo,panelGo);
            titleGoTransform.localPosition = new Vector3(50, -50, 0);
            titleGoTransform.anchorMin = new Vector2(0,1);
            titleGoTransform.anchorMax = new Vector2(0,1);

            // ��������
            GameObject titleImg = new GameObject("img_title", typeof(Image));
            titleImg.GetComponent<Image>().raycastTarget = false;
            RectTransform titleImgTransform = titleImg.GetComponent<RectTransform>();

            titleImgTransform.sizeDelta = new Vector2(150, 60);
            GameObjectUtility.SetParentAndAlign(titleImg,titleGo);
            titleImgTransform.localPosition = new Vector3(150, 15, 0);

            // ���ذ�ť
            GameObject btnClose = new GameObject("_BtnClose", typeof(Image),typeof(Button));
            RectTransform btnCloseTransform = btnClose.GetComponent<RectTransform>();
            btnCloseTransform.sizeDelta = new Vector2(80,80);
            Image btnCloseImgComp = btnClose.GetComponent<Image>();
            btnCloseImgComp.color = new Color32(255, 90, 90, 255);
            GameObjectUtility.SetParentAndAlign(btnClose,titleGo);

            // �������常�ڵ�
            GameObject rootGo = new GameObject("con_root", typeof(RectTransform));
            RectTransform rootGoTransform = rootGo.GetComponent<RectTransform>();
            GameObjectUtility.SetParentAndAlign(rootGo, panelGo);
            rootGoTransform.sizeDelta = new Vector2(1334, 750);

            // TopBar
            GameObject topBarGo = new GameObject("_TopBar", typeof(RectTransform));
            RectTransform topBarGoTransform = topBarGo.GetComponent<RectTransform>();
            topBarGoTransform.sizeDelta = new Vector2(0, 0);
            GameObjectUtility.SetParentAndAlign(topBarGo, rootGo);
            topBarGoTransform.localPosition = new Vector3(-15, -5, 0);
            topBarGoTransform.anchorMin = new Vector2(1, 1);
            topBarGoTransform.anchorMax = new Vector2(1, 1);

            return panelGo;
        }

        /// <summary>
        /// �������棨���رհ�ť��
        /// </summary>
        /// <param name="menuCommand"></param>
        /// <returns></returns>
        [MenuItem("GameObject/UI����/����/PopPanel", priority = 13)]
        static public GameObject CreatPopPanelByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Panel");
            GameObject panelGo = Selection.activeGameObject;
            panelGo.name = "Xxx" + "PopPanel";
            GameObjectUtility.SetParentAndAlign(panelGo, menuCommand.context as GameObject);
            Image imageComp = panelGo.GetComponent<Image>();
            GameObject.DestroyImmediate(imageComp);

            // �����������ڵ�
            GameObject bgGo = new GameObject("con_bg", typeof(RectTransform));
            RectTransform rectTransform = bgGo.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(2334, 1750);
            GameObjectUtility.SetParentAndAlign(bgGo, panelGo);

            // ����ͼ
            GameObject bgImg = new GameObject("img_bg", typeof(Image));
            bgImg.GetComponent<Image>().raycastTarget = false;
            RectTransform bgGoTransform = bgImg.GetComponent<RectTransform>();
            bgGoTransform.sizeDelta = new Vector2(0, 0);
            bgGoTransform.anchorMin = new Vector2(0, 0);
            bgGoTransform.anchorMax = new Vector2(1, 1);
            Image ImgBgComp = bgImg.GetComponent<Image>();
            ImgBgComp.color = new Color32(50, 50, 50, 100);
            GameObjectUtility.SetParentAndAlign(bgImg, bgGo);


            // �������常�ڵ�
            GameObject rootGo = new GameObject("con_root", typeof(RectTransform), typeof(Image));
            RectTransform rootGoTransform = rootGo.GetComponent<RectTransform>();
            GameObjectUtility.SetParentAndAlign(rootGo, panelGo);
            rootGoTransform.sizeDelta = new Vector2(1000, 500);

            // ���ذ�ť
            GameObject btnClose = new GameObject("_BtnClose", typeof(Image), typeof(Button));
            RectTransform btnCloseTransform = btnClose.GetComponent<RectTransform>();
            btnCloseTransform.sizeDelta = new Vector2(80, 80);
            Image btnCloseImgComp = btnClose.GetComponent<Image>();
            btnCloseImgComp.color = new Color32(255, 90, 90, 255);
            GameObjectUtility.SetParentAndAlign(btnClose, rootGo);
            btnCloseTransform.anchorMin = new Vector2(1, 1);
            btnCloseTransform.anchorMax = new Vector2(1, 1);

            return panelGo;
        }

        /// <summary>
        /// �������棨�հ�����رգ�
        /// </summary>
        /// <param name="menuCommand"></param>
        /// <returns></returns>
        [MenuItem("GameObject/UI����/����/TipsPopPanel", priority = 13)]
        static public GameObject CreatTipsPopPanelByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Panel");
            GameObject panelGo = Selection.activeGameObject;
            panelGo.name = "Xxx" + "TipsPopPanel";
            GameObjectUtility.SetParentAndAlign(panelGo, menuCommand.context as GameObject);
            Image imageComp = panelGo.GetComponent<Image>();
            GameObject.DestroyImmediate(imageComp);

            // �����������ڵ�
            GameObject bgGo = new GameObject("con_bg", typeof(RectTransform));
            RectTransform rectTransform = bgGo.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(2334, 1750);
            GameObjectUtility.SetParentAndAlign(bgGo, panelGo);

            // ����ͼ
            GameObject bgImg = new GameObject("_BtnClose", typeof(Image), typeof(Button));
            RectTransform bgGoTransform = bgImg.GetComponent<RectTransform>();
            bgGoTransform.sizeDelta = new Vector2(0, 0);
            bgGoTransform.anchorMin = new Vector2(0, 0);
            bgGoTransform.anchorMax = new Vector2(1, 1);
            Image ImgBgComp = bgImg.GetComponent<Image>();
            ImgBgComp.color = new Color32(50, 50, 50, 100);
            GameObjectUtility.SetParentAndAlign(bgImg, bgGo);

            // �������常�ڵ�
            GameObject rootGo = new GameObject("con_root", typeof(RectTransform), typeof(Image));
            RectTransform rootGoTransform = rootGo.GetComponent<RectTransform>();
            GameObjectUtility.SetParentAndAlign(rootGo, panelGo);
            rootGoTransform.sizeDelta = new Vector2(1000, 500);

            return panelGo;
        }

        [MenuItem("GameObject/UI����/���/Text", priority = 13)]
        static public GameObject CreatTextByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatText(menuCommand);
        }

        [MenuItem("GameObject/UI����/���/Text(���)", priority = 13)]
        static public GameObject CreatOutlineTextByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatOutlineText(menuCommand);
        }

        
        /// <summary>
        /// �󲿷�Text����Ҫ������Ӧ�¼�������RaycastTarget���Բ��ù�ѡ���������塣
        /// </summary>
        /// <param name="menuCommand"></param>
        //[MenuItem("UI����/���/Text", false)]
        static public GameObject CreatText(MenuCommand menuCommand)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Text");
            GameObject go = Selection.activeGameObject;
            go.name = "_TxtXxx";
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            go.GetComponent<Text>().raycastTarget = false;
            go.GetComponent<Text>().font = (Font)AssetDatabase.LoadAssetAtPath<Font>("Assets/App/Pro/GameRes/Fonts/songHeavy.otf");
            return go;
        }

        //[MenuItem("UI����/���/Text(���)", false)]
        static public GameObject CreatOutlineText(MenuCommand menuCommand)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Text");
            GameObject go = Selection.activeGameObject;
            go.name = "_TxtXxx";
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            go.GetComponent<Text>().raycastTarget = false;
            go.GetComponent<Text>().font = (Font)AssetDatabase.LoadAssetAtPath<Font>("Assets/App/Pro/GameRes/Fonts/songHeavy.otf");
            go.AddComponent<Outline>();
            return go;
        }

        [MenuItem("GameObject/UI����/���/Image", priority = 13)]
        static public GameObject CreatImageByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatImage(menuCommand);
        }

        /// <summary>
        /// �󲿷�Image����Ҫ������Ӧ�¼�������RaycastTarget���Բ��ù�ѡ��
        /// </summary>
        /// <param name="menuCommand"></param>
        //[MenuItem("UI����/���/Image", false)]
        static public GameObject CreatImage(MenuCommand menuCommand)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Image");
            GameObject go = Selection.activeGameObject;
            go.name = "_ImgXxx";
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            go.GetComponent<Image>().raycastTarget = false;
            return go;
        }

        [MenuItem("GameObject/UI����/���/Button", priority = 13)]
        static public GameObject CreatButtonByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatButton(menuCommand);
        }

        /// <summary>
        /// buttonһ����Ҫ������Ӧ�¼�������RaycastTarget��Ĭ�Ϲ�ѡ��
        /// </summary>
        /// <param name="menuCommand"></param>
        //[MenuItem("UI����/���/Button", false)]
        static public GameObject CreatButton(MenuCommand menuCommand)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Button");
            GameObject go = Selection.activeGameObject;
            go.name = "_BtnXxx";
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            ChangeAllTextFont(ref go);
            go.transform.GetChild(0).gameObject.name = "_TxtXxx";

            return go;
        }

        [MenuItem("GameObject/UI����/���/Toggle", priority = 13)]
        static public GameObject CreatToggleByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatToggle(menuCommand);
        }

        //[MenuItem("UI����/���/Toggle", false)]
        static public GameObject CreatToggle(MenuCommand menuCommand)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Toggle");
            GameObject go = Selection.activeGameObject;
            go.name = "_TglXxx";
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            ChangeAllTextFont(ref go);

            GameObject bg = go.transform.Find("Background").gameObject;
            bg.name = "tgl_bg";
            GameObject selectImg = bg.transform.Find("Checkmark").gameObject;
            selectImg.name = "tgl_select";
            GameObject tglName = go.transform.Find("Label").gameObject;
            tglName.name = "_TxtTglXxx";
            return go;
        }

        /// <summary>
        /// �������������ͣ�1���л��� 2���޻���
        /// </summary>
        /// <param name="menuCommand"></param>
        /// <returns></returns>
        [MenuItem("GameObject/UI����/���/Slider", priority = 13)]
        static public GameObject CreatSliderByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatSlider(menuCommand,true);
        }

        [MenuItem("GameObject/UI����/���/Slider(�޻�����)", priority = 13)]
        static public GameObject CreatSliderNoBarByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatSlider(menuCommand,false);
        }

        //[MenuItem("UI����/���/Slider", false)]
        static public GameObject CreatSlider(MenuCommand menuCommand,bool isNeedHandle)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Slider");
            GameObject go = Selection.activeGameObject;
            go.name = "_SldXxx";
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);

            GameObject bg = go.transform.Find("Background").gameObject;
            bg.name = "sld_bg";
            GameObject fillArea = go.transform.Find("Fill Area").gameObject;
            fillArea.name = "fill_area";
            GameObject fillImg = fillArea.transform.Find("Fill").gameObject;
            fillImg.name = "_ImgFill";

            GameObject handleBar = go.transform.Find("Handle Slide Area").gameObject;

            if (!isNeedHandle)
            {
                GameObject.DestroyImmediate(handleBar);
            }
            else
            {
                handleBar.name = "handle_bar";
                GameObject handleImg = handleBar.transform.Find("Handle").gameObject;
                handleImg.name = "img_handle";
            }

            return go;
        }

        /// <summary>
        /// �����
        /// </summary>
        /// <param name="menuCommand"></param>
        /// <returns></returns>
        [MenuItem("GameObject/UI����/���/InputField", priority = 13)]
        static public GameObject CreatInputFieldByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatInputField(menuCommand);
        }

        //[MenuItem("UI����/���/InputField(Ĭ������7���ַ�)", false)]
        static public GameObject CreatInputField(MenuCommand menuCommand)
        {
            EditorApplication.ExecuteMenuItem("GameObject/UI/Input Field");
            GameObject go = Selection.activeGameObject;
            go.name = "_IfdXxx";
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            ChangeAllTextFont(ref go);
            InputField inputField = go.GetComponent<InputField>();
            inputField.characterLimit = 7;

            GameObject placeholder = go.transform.Find("Placeholder").gameObject;
            placeholder.name = "_TxtPlaceHolder";
            GameObject context = go.transform.Find("Text").gameObject;
            context.name = "_TxtInput";

            return go;
        }

        [MenuItem("GameObject/UI����/���/ScrollView(Horizontal)", priority = 13)]
        static public GameObject CreatScrollViewHorizontalByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatScrollView(menuCommand,true);
        }

        [MenuItem("GameObject/UI����/���/ScrollView(Vertical)", priority = 13)]
        static public GameObject CreatScrollViewVerticalByHierarchyRigtMenu(MenuCommand menuCommand)
        {
            return CreatScrollView(menuCommand,false);
        }

        /// <summary>
        /// �����б�ˮƽ����ֱ��
        /// </summary>
        /// <param name="menuCommand"></param>
        /// <param name="isHorizontal"></param>
        /// <returns></returns>
        static public GameObject CreatScrollView(MenuCommand menuCommand,bool isHorizontal)
        {
            //_LoopScrollView
            EditorApplication.ExecuteMenuItem("GameObject/UI/Image");
            GameObject go = Selection.activeGameObject;
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            go.GetComponent<RectTransform>().sizeDelta = new Vector2(400, 400);
            Image ImgBgComp = go.GetComponent<Image>();
            ImgBgComp.raycastTarget = false;
            ImgBgComp.color = new Color32(255, 255, 255, 100);
            ImgBgComp.enabled = false;

            //TemplateItem
            GameObject templateItem = new GameObject("TemplateXxxItem", typeof(RectTransform), typeof(Image));
            GameObjectUtility.SetParentAndAlign(templateItem, go);

            //ViewPort
            GameObject viewPort = new GameObject("view_port", typeof(RectTransform),typeof(Image),typeof(RectMask2D));
            RectTransform viewPortTransform = viewPort.GetComponent<RectTransform>();
            viewPortTransform.sizeDelta = new Vector2(0, 0);
            viewPortTransform.anchorMin = new Vector2(0, 0);
            viewPortTransform.anchorMax = new Vector2(1, 1);
            GameObjectUtility.SetParentAndAlign(viewPort, go);
            Image ImgComp = viewPort.GetComponent<Image>();
            ImgComp.color = new Color32(255, 255, 255, 100);

            // Content
            GameObject content = new GameObject("content", typeof(RectTransform), typeof(GridLayoutGroup),typeof(ContentSizeFitter));
            RectTransform contentTransform = content.GetComponent<RectTransform>();
            contentTransform.sizeDelta = new Vector2(0, 0);
            contentTransform.anchorMin = new Vector2(0, 0);
            contentTransform.anchorMax = new Vector2(1, 1);
            GameObjectUtility.SetParentAndAlign(content, viewPort);

            //loop
            if (isHorizontal)
            {
                go.name = "_LshXxx";
                go.AddComponent<UDLib.UI.CHorizontalLoopScrollRect>();
                UDLib.UI.CHorizontalLoopScrollRect cHorizontalLoopScrollRect = go.GetComponent<UDLib.UI.CHorizontalLoopScrollRect>();
                cHorizontalLoopScrollRect.content = contentTransform;
                cHorizontalLoopScrollRect.viewport = viewPortTransform;
            }
            else
            {
                go.name = "_LsvXxx";
                go.AddComponent<UDLib.UI.CVerticalLoopScrollRect>();
                UDLib.UI.CVerticalLoopScrollRect cVerticalLoopScrollRect = go.GetComponent<UDLib.UI.CVerticalLoopScrollRect>();
                cVerticalLoopScrollRect.content = contentTransform;
                cVerticalLoopScrollRect.viewport = viewPortTransform;
            }

            return go;
        }

        /// <summary>
        /// ����������������ı�����
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        static public void ChangeAllTextFont(ref GameObject go)
        {
            if (go == null)
            {
                return;
            }

            Font targetFont = (Font)AssetDatabase.LoadAssetAtPath<Font>("Assets/App/Pro/GameRes/Fonts/songHeavy.otf");
            Component[] components = go.GetComponentsInChildren<Text>();

            foreach (Text text in components)
            {
                text.font = targetFont;
                text.fontSize = 10;
            }
        }
    }
}
