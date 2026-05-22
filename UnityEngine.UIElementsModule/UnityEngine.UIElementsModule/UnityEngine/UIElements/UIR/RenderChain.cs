using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnityEngine.UIElements.UIR.Implementation;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000153 RID: 339
	public class RenderChain
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x000072EF File Offset: 0x000054EF
		public RenderChainCommand firstCommand
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000072FC File Offset: 0x000054FC
		public void Constructor(IPanel panelObj, UIRenderDevice deviceObj, UIRAtlasManager atlasMan, VectorImageManager vectorImageMan)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00007309 File Offset: 0x00005509
		public void Destructor()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00007316 File Offset: 0x00005516
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00007323 File Offset: 0x00005523
		public bool disposed
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

		// Token: 0x060007A9 RID: 1961 RVA: 0x00007330 File Offset: 0x00005530
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		public void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				if (disposing)
				{
					this.Destructor();
				}
				this.disposed = true;
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00007342 File Offset: 0x00005542
		public void ProcessChanges()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000734F File Offset: 0x0000554F
		public void Render()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0000735C File Offset: 0x0000555C
		public void ProcessTextRegen(bool timeSliced)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00007369 File Offset: 0x00005569
		public void UIEOnChildAdded(VisualElement parent, VisualElement ve, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00007376 File Offset: 0x00005576
		public void UIEOnChildrenReordered(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00007383 File Offset: 0x00005583
		public void UIEOnChildRemoving(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00007390 File Offset: 0x00005590
		public void StopTrackingGroupTransformElement(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0000739D File Offset: 0x0000559D
		public void UIEOnClippingChanged(VisualElement ve, bool hierarchical)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000073AA File Offset: 0x000055AA
		public void UIEOnOpacityChanged(VisualElement ve, [Optional] bool hierarchical)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000073B7 File Offset: 0x000055B7
		public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000073C4 File Offset: 0x000055C4
		public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x000073D1 File Offset: 0x000055D1
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x000073DE File Offset: 0x000055DE
		public IPanel panel
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

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000073EB File Offset: 0x000055EB
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x000073F8 File Offset: 0x000055F8
		public UIRenderDevice device
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

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00007405 File Offset: 0x00005605
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00007412 File Offset: 0x00005612
		public UIRAtlasManager atlasManager
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

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0000741F File Offset: 0x0000561F
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0000742C File Offset: 0x0000562C
		public VectorImageManager vectorImageManager
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

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00007439 File Offset: 0x00005639
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00007446 File Offset: 0x00005646
		public UnityEngine.UIElements.UIR.Implementation.UIRStylePainter painter
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00007453 File Offset: 0x00005653
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00007460 File Offset: 0x00005660
		public bool drawStats
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0000746D File Offset: 0x0000566D
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x0000747A File Offset: 0x0000567A
		public bool drawInCameras
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00007487 File Offset: 0x00005687
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00007494 File Offset: 0x00005694
		public Shader defaultShader
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x000074A1 File Offset: 0x000056A1
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x000074AE File Offset: 0x000056AE
		public Shader defaultWorldSpaceShader
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x000074BB File Offset: 0x000056BB
		public Material GetStandardMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000074C8 File Offset: 0x000056C8
		public Material GetStandardWorldSpaceMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000074D5 File Offset: 0x000056D5
		public void EnsureFitsDepth(int depth)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000074E2 File Offset: 0x000056E2
		public void ChildWillBeRemoved(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000074EF File Offset: 0x000056EF
		public RenderChainCommand AllocCommand()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000074FC File Offset: 0x000056FC
		public void FreeCommand(RenderChainCommand cmd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00007509 File Offset: 0x00005709
		public void OnRenderCommandAdded(RenderChainCommand command)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00007516 File Offset: 0x00005716
		public void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00007523 File Offset: 0x00005723
		public void AddTextElement(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00007530 File Offset: 0x00005730
		public void RemoveTextElement(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0000753D File Offset: 0x0000573D
		public void OnGroupTransformElementChangedTransform(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0000754A File Offset: 0x0000574A
		public void BeforeRenderDeviceRelease()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00007557 File Offset: 0x00005757
		public void AfterRenderDeviceRelease()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00007564 File Offset: 0x00005764
		public void RecreateDevice()
		{
			this.BeforeRenderDeviceRelease();
			this.AfterRenderDeviceRelease();
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00007575 File Offset: 0x00005775
		public static void OnRenderNodeExecute(IntPtr obj)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00007582 File Offset: 0x00005782
		public static void OnRegisterIntermediateRenderers(Camera camera)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0000758F File Offset: 0x0000578F
		public void RepaintAtlassedElements()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0000759C File Offset: 0x0000579C
		public void OnFontReset(Font font)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000075A9 File Offset: 0x000057A9
		public void DrawStats()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000075B6 File Offset: 0x000057B6
		public static VisualElement GetFirstElementInPanel(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000210 RID: 528
		public struct RenderChainStaticIndexAllocator
		{
		}
	}
}
