using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
	[SerializeField] private Text m_Text;
	[SerializeField] private Button m_AddBtn;
	[SerializeField] private Button m_RestBtn;

	/// <summary>
	/// 记录点击次数
	/// </summary>
	private int mClickCount;

	private void Start()
	{
		m_AddBtn.onClick.AddListener(OnAddButtonClick);
		m_RestBtn.onClick.AddListener(OnButtonResetClick);
	}

	private void OnButtonResetClick()
	{
		mClickCount = 0;
		SetText();
	}

	private void OnAddButtonClick()
	{
		mClickCount++;
		SetText();
	}

	private void SetText()
	{
		m_Text.text = string.Format("已点击{0}次", mClickCount);
	}
}
