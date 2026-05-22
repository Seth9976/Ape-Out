using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000067 RID: 103
	public class VisualElementPanelActivator
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00003E16 File Offset: 0x00002016
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003E23 File Offset: 0x00002023
		public bool isActive
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00003E30 File Offset: 0x00002030
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00003E3D File Offset: 0x0000203D
		public bool isDetaching
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003E4A File Offset: 0x0000204A
		public void SetActive(bool action)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003E57 File Offset: 0x00002057
		public void SendActivation()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003E64 File Offset: 0x00002064
		public void SendDeactivation()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000A1D8 File Offset: 0x000083D8
		public void OnEnter(AttachToPanelEvent evt)
		{
			bool isActive = this.isActive;
			if (isActive)
			{
				this.SendActivation();
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000A1FC File Offset: 0x000083FC
		public void OnLeave(DetachFromPanelEvent evt)
		{
			bool isActive = this.isActive;
			if (isActive)
			{
				this.isDetaching = true;
				try
				{
					this.SendDeactivation();
				}
				finally
				{
					this.isDetaching = false;
				}
			}
		}
	}
}
