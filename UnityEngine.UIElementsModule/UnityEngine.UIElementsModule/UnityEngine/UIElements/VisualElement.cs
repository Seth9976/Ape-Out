using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine.UIElements.Experimental;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005D RID: 93
	public class VisualElement : Focusable
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000032AE File Offset: 0x000014AE
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000032BB File Offset: 0x000014BB
		public bool isCompositeRoot
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000032C8 File Offset: 0x000014C8
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000032D5 File Offset: 0x000014D5
		public string viewDataKey
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000032E2 File Offset: 0x000014E2
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000032EF File Offset: 0x000014EF
		public bool enableViewDataPersistence
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000032FC File Offset: 0x000014FC
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00003309 File Offset: 0x00001509
		public Object userData
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00003316 File Offset: 0x00001516
		public override bool canGrabFocus
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00009610 File Offset: 0x00007810
		public override FocusController focusController
		{
			get
			{
				IPanel panel = this.panel;
				return (panel != null) ? panel.focusController : null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00003323 File Offset: 0x00001523
		public IEventInterpreter eventInterpreter
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00003330 File Offset: 0x00001530
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000333D File Offset: 0x0000153D
		public UsageHints usageHints
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000334A File Offset: 0x0000154A
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00003357 File Offset: 0x00001557
		public RenderHints renderHints
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00009634 File Offset: 0x00007834
		public ITransform transform
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00003371 File Offset: 0x00001571
		public Vector3 UnityEngine.UIElements.ITransform.position
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000337E File Offset: 0x0000157E
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000338B File Offset: 0x0000158B
		public Quaternion UnityEngine.UIElements.ITransform.rotation
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00003398 File Offset: 0x00001598
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000033A5 File Offset: 0x000015A5
		public Vector3 UnityEngine.UIElements.ITransform.scale
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

		// Token: 0x060001A7 RID: 423 RVA: 0x000033B2 File Offset: 0x000015B2
		public Vector3 ComputeGlobalScale()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000033BF File Offset: 0x000015BF
		public Matrix4x4 UnityEngine.UIElements.ITransform.matrix
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000033CC File Offset: 0x000015CC
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000033D9 File Offset: 0x000015D9
		public bool isLayoutManual
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00009648 File Offset: 0x00007848
		public float scaledPixelsPerPoint
		{
			get
			{
				return (this.panel == null) ? GUIUtility.pixelsPerPoint : this.panel.TryCast<BaseVisualElementPanel>().scaledPixelsPerPoint;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000033E6 File Offset: 0x000015E6
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000033F3 File Offset: 0x000015F3
		public Rect layout
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00003400 File Offset: 0x00001600
		public Rect contentRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000340D File Offset: 0x0000160D
		public Rect paddingRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000967C File Offset: 0x0000787C
		public static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect)
		{
			Vector2 vector = VisualElement.MultiplyMatrix44Point2(lhc, rect.min);
			Vector2 vector2 = VisualElement.MultiplyMatrix44Point2(lhc, rect.max);
			return Rect.MinMaxRect(Math.Min(vector.x, vector2.x), Math.Min(vector.y, vector2.y), Math.Max(vector.x, vector2.x), Math.Max(vector.y, vector2.y));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000096F4 File Offset: 0x000078F4
		public static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point)
		{
			Vector2 vector;
			vector.x = lhs.m00 * point.x + lhs.m01 * point.y + lhs.m03;
			vector.y = lhs.m10 * point.x + lhs.m11 * point.y + lhs.m13;
			return vector;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000341A File Offset: 0x0000161A
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00003427 File Offset: 0x00001627
		public bool isBoundingBoxDirty
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00003434 File Offset: 0x00001634
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00003441 File Offset: 0x00001641
		public bool isWorldBoundingBoxDirty
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000344E File Offset: 0x0000164E
		public Rect boundingBox
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000345B File Offset: 0x0000165B
		public Rect worldBoundingBox
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00003468 File Offset: 0x00001668
		public void UpdateBoundingBox()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00003475 File Offset: 0x00001675
		public void UpdateWorldBoundingBox()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000975C File Offset: 0x0000795C
		public Rect worldBound
		{
			get
			{
				Matrix4x4 worldTransform = this.worldTransform;
				return VisualElement.TransformAlignedRect(worldTransform, this.rect);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00009784 File Offset: 0x00007984
		public Rect localBound
		{
			get
			{
				Matrix4x4 matrix = this.transform.matrix;
				Rect layout = this.layout;
				return VisualElement.TransformAlignedRect(matrix, layout);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000097B0 File Offset: 0x000079B0
		public Rect rect
		{
			get
			{
				return new Rect(0f, 0f, this.layout.width, this.layout.height);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00003482 File Offset: 0x00001682
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000348F File Offset: 0x0000168F
		public bool isWorldTransformDirty
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000349C File Offset: 0x0000169C
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x000034A9 File Offset: 0x000016A9
		public bool isWorldTransformInverseDirty
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000034B6 File Offset: 0x000016B6
		public Matrix4x4 worldTransform
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000034C3 File Offset: 0x000016C3
		public Matrix4x4 worldTransformInverse
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000034D0 File Offset: 0x000016D0
		public void UpdateWorldTransform()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000034DD File Offset: 0x000016DD
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000034EA File Offset: 0x000016EA
		public bool isWorldClipDirty
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000034F7 File Offset: 0x000016F7
		public Rect worldClip
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00003504 File Offset: 0x00001704
		public Rect worldClipMinusGroup
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000097F0 File Offset: 0x000079F0
		public void EnsureWorldTransformAndClipUpToDate()
		{
			bool isWorldTransformDirty = this.isWorldTransformDirty;
			if (isWorldTransformDirty)
			{
				this.UpdateWorldTransform();
			}
			bool isWorldClipDirty = this.isWorldClipDirty;
			if (isWorldClipDirty)
			{
				this.UpdateWorldClip();
				this.isWorldClipDirty = false;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00003511 File Offset: 0x00001711
		public void UpdateWorldClip()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000351E File Offset: 0x0000171E
		public Rect SubstractBorderPadding(Rect worldRect)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000982C File Offset: 0x00007A2C
		public static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat)
		{
			Rect rect = position;
			Vector3 vector = mat.MultiplyPoint3x4(new Vector3(rect.x, rect.y, 0f));
			Vector3 vector2 = mat.MultiplyPoint3x4(new Vector3(rect.x + rect.width, rect.y, 0f));
			Vector3 vector3 = mat.MultiplyPoint3x4(new Vector3(rect.x, rect.y + rect.height, 0f));
			Vector3 vector4 = mat.MultiplyPoint3x4(new Vector3(rect.x + rect.width, rect.y + rect.height, 0f));
			return Rect.MinMaxRect(Mathf.Min(vector.x, Mathf.Min(vector2.x, Mathf.Min(vector3.x, vector4.x))), Mathf.Min(vector.y, Mathf.Min(vector2.y, Mathf.Min(vector3.y, vector4.y))), Mathf.Max(vector.x, Mathf.Max(vector2.x, Mathf.Max(vector3.x, vector4.x))), Mathf.Max(vector.y, Mathf.Max(vector2.y, Mathf.Max(vector3.y, vector4.y))));
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000352B File Offset: 0x0000172B
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00003538 File Offset: 0x00001738
		public PseudoStates pseudoStates
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00003545 File Offset: 0x00001745
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00003552 File Offset: 0x00001752
		public PickingMode pickingMode
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000355F File Offset: 0x0000175F
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000356C File Offset: 0x0000176C
		public string name
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00003579 File Offset: 0x00001779
		public List<string> classList
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00003586 File Offset: 0x00001786
		public string fullTypeName
		{
			get
			{
				return this.typeData.fullTypeName;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00003593 File Offset: 0x00001793
		public string typeName
		{
			get
			{
				return this.typeData.typeName;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000035A0 File Offset: 0x000017A0
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x000035AD File Offset: 0x000017AD
		public YogaNode yogaNode
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000035BA File Offset: 0x000017BA
		public ComputedStyle sharedStyle
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000035C7 File Offset: 0x000017C7
		public ComputedStyle computedStyle
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000035D4 File Offset: 0x000017D4
		public bool hasInlineStyle
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00009988 File Offset: 0x00007B88
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000035E1 File Offset: 0x000017E1
		public float opacity
		{
			get
			{
				return this.resolvedStyle.opacity;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000035EE File Offset: 0x000017EE
		public void ChangeIMGUIContainerCount(int delta)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000035FB File Offset: 0x000017FB
		public override void ExecuteDefaultAction(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00003608 File Offset: 0x00001808
		public sealed override void Focus()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00003615 File Offset: 0x00001815
		public void SetPanel(BaseVisualElementPanel p)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00003622 File Offset: 0x00001822
		public void WillChangePanel(BaseVisualElementPanel destinationPanel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000362F File Offset: 0x0000182F
		public void HasChangedPanel(BaseVisualElementPanel prevPanel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000363C File Offset: 0x0000183C
		public sealed override void SendEvent(EventBase e)
		{
			BaseVisualElementPanel elementPanel = this.elementPanel;
			if (elementPanel != null)
			{
				elementPanel.SendEvent(e, DispatchMode.Default);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003653 File Offset: 0x00001853
		public void IncrementVersion(VersionChangeType changeType)
		{
			BaseVisualElementPanel elementPanel = this.elementPanel;
			if (elementPanel != null)
			{
				elementPanel.OnVersionChanged(this, changeType);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000366A File Offset: 0x0000186A
		public void InvokeHierarchyChanged(HierarchyChangeType changeType)
		{
			BaseVisualElementPanel elementPanel = this.elementPanel;
			if (elementPanel != null)
			{
				elementPanel.InvokeHierarchyChanged(this, changeType);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000099A8 File Offset: 0x00007BA8
		public bool SetEnabledFromHierarchy(bool state)
		{
			return this.SetEnabledFromHierarchyPrivate(state);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00003681 File Offset: 0x00001881
		public bool SetEnabledFromHierarchyPrivate(bool state)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000368E File Offset: 0x0000188E
		public bool isParentEnabledInHierarchy
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000099C4 File Offset: 0x00007BC4
		public bool enabledInHierarchy
		{
			get
			{
				return (this.pseudoStates & PseudoStates.Disabled) != PseudoStates.Disabled;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000369B File Offset: 0x0000189B
		// (set) Token: 0x060001EA RID: 490 RVA: 0x000036A8 File Offset: 0x000018A8
		public bool enabledSelf
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

		// Token: 0x060001EB RID: 491 RVA: 0x000099E8 File Offset: 0x00007BE8
		public void SetEnabled(bool value)
		{
			bool flag = this.enabledSelf == value;
			if (!flag)
			{
				this.enabledSelf = value;
				this.PropagateEnabledToChildren(value);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000036B5 File Offset: 0x000018B5
		public void PropagateEnabledToChildren(bool value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00009A18 File Offset: 0x00007C18
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000036C2 File Offset: 0x000018C2
		public bool visible
		{
			get
			{
				return this.resolvedStyle.visibility == Visibility.Visible;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000036CF File Offset: 0x000018CF
		public void MarkDirtyRepaint()
		{
			this.IncrementVersion(VersionChangeType.Repaint);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000036DE File Offset: 0x000018DE
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000036EB File Offset: 0x000018EB
		public Action<MeshGenerationContext> generateVisualContent
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

		// Token: 0x060001F2 RID: 498 RVA: 0x000036F8 File Offset: 0x000018F8
		public void InvokeGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00009A38 File Offset: 0x00007C38
		public void GetFullHierarchicalViewDataKey(StringBuilder key)
		{
			bool flag = this.parent != null;
			if (flag)
			{
				this.parent.GetFullHierarchicalViewDataKey(key);
			}
			bool flag2 = !String.IsNullOrEmpty(this.viewDataKey);
			if (flag2)
			{
				key.Append("__");
				key.Append(this.viewDataKey);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00009A90 File Offset: 0x00007C90
		public string GetFullHierarchicalViewDataKey()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.GetFullHierarchicalViewDataKey(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00003705 File Offset: 0x00001905
		public T GetOrCreateViewData<T>(Object existing, string key) where T : class, new()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00003712 File Offset: 0x00001912
		public T GetOrCreateViewData<T>(ScriptableObject existing, string key) where T : ScriptableObject
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000371F File Offset: 0x0000191F
		public void OverwriteFromViewData(Object obj, string key)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000372C File Offset: 0x0000192C
		public void SaveViewData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00009AB8 File Offset: 0x00007CB8
		public bool IsViewDataPersitenceSupportedOnChildren(bool existingState)
		{
			bool flag = existingState;
			bool flag2 = String.IsNullOrEmpty(this.viewDataKey) && this != this.contentContainer;
			if (flag2)
			{
				flag = false;
			}
			bool flag3 = this.parent != null && this == this.parent.contentContainer;
			if (flag3)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00003739 File Offset: 0x00001939
		public void OnViewDataReady(bool enablePersistence)
		{
			this.enableViewDataPersistence = enablePersistence;
			this.OnViewDataReady();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000374B File Offset: 0x0000194B
		public virtual void OnViewDataReady()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00009B10 File Offset: 0x00007D10
		public virtual bool ContainsPoint(Vector2 localPoint)
		{
			return this.rect.Contains(localPoint);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00009B34 File Offset: 0x00007D34
		public virtual bool Overlaps(Rect rectangle)
		{
			return this.rect.Overlaps(rectangle, true);
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000374E File Offset: 0x0000194E
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0000375B File Offset: 0x0000195B
		public bool requireMeasureFunction
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

		// Token: 0x06000200 RID: 512 RVA: 0x00003768 File Offset: 0x00001968
		public void AssignMeasureFunction()
		{
			this.yogaNode.SetMeasureFunction(new MeasureFunction(this.<AssignMeasureFunction>b__202_0));
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00003783 File Offset: 0x00001983
		public void RemoveMeasureFunction()
		{
			this.yogaNode.SetMeasureFunction(null);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00009B58 File Offset: 0x00007D58
		public virtual Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return new Vector2(float.NaN, float.NaN);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00009B7C File Offset: 0x00007D7C
		public YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			Debug.Assert(node == this.yogaNode, "YogaNode instance mismatch");
			Vector2 vector = this.DoMeasure(width, (VisualElement.MeasureMode)widthMode, height, (VisualElement.MeasureMode)heightMode);
			float scaledPixelsPerPoint = this.scaledPixelsPerPoint;
			return MeasureOutput.Make(AlignmentUtils.RoundToPixelGrid(vector.x, scaledPixelsPerPoint, 0.02f), AlignmentUtils.RoundToPixelGrid(vector.y, scaledPixelsPerPoint, 0.02f));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00009BE0 File Offset: 0x00007DE0
		public void SetSize(Vector2 size)
		{
			Rect layout = this.layout;
			layout.width = size.x;
			layout.height = size.y;
			this.layout = layout;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00003793 File Offset: 0x00001993
		public void FinalizeLayout()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000037A0 File Offset: 0x000019A0
		public void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000037AD File Offset: 0x000019AD
		public void SetSharedStyles(ComputedStyle sharedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000037BA File Offset: 0x000019BA
		public void ResetPositionProperties()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000037C7 File Offset: 0x000019C7
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000037D4 File Offset: 0x000019D4
		public IEnumerable<string> GetClasses()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000037E1 File Offset: 0x000019E1
		public List<string> GetClassesForIteration()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000037EE File Offset: 0x000019EE
		public void ClearClassList()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000037FB File Offset: 0x000019FB
		public void AddToClassList(string className)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00003808 File Offset: 0x00001A08
		public void RemoveFromClassList(string className)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00009C1C File Offset: 0x00007E1C
		public void ToggleInClassList(string className)
		{
			bool flag = this.ClassListContains(className);
			if (flag)
			{
				this.RemoveFromClassList(className);
			}
			else
			{
				this.AddToClassList(className);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00009C48 File Offset: 0x00007E48
		public void EnableInClassList(string className, bool enable)
		{
			if (enable)
			{
				this.AddToClassList(className);
			}
			else
			{
				this.RemoveFromClassList(className);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00003815 File Offset: 0x00001A15
		public bool ClassListContains(string cls)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00009C70 File Offset: 0x00007E70
		public Object FindAncestorUserData()
		{
			for (VisualElement visualElement = this.parent; visualElement != null; visualElement = visualElement.parent)
			{
				bool flag = visualElement.userData != null;
				if (flag)
				{
					return visualElement.userData;
				}
			}
			return null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00009CB4 File Offset: 0x00007EB4
		public Object GetProperty(PropertyName key)
		{
			VisualElement.CheckUserKeyArgument(key);
			Object @object;
			this.TryGetPropertyInternal(key, out @object);
			return @object;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00003822 File Offset: 0x00001A22
		public void SetProperty(PropertyName key, Object value)
		{
			VisualElement.CheckUserKeyArgument(key);
			this.SetPropertyInternal(key, value);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00009CD8 File Offset: 0x00007ED8
		public bool HasProperty(PropertyName key)
		{
			VisualElement.CheckUserKeyArgument(key);
			Object @object;
			return this.TryGetPropertyInternal(key, out @object);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003835 File Offset: 0x00001A35
		public bool TryGetPropertyInternal(PropertyName key, out Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00003842 File Offset: 0x00001A42
		public static void CheckUserKeyArgument(PropertyName key)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000384F File Offset: 0x00001A4F
		public void SetPropertyInternal(PropertyName key, Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000385C File Offset: 0x00001A5C
		public void UpdateCursorStyle(long eventType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00009CFC File Offset: 0x00007EFC
		public VisualElementAnimationSystem GetAnimationSystem()
		{
			bool flag = this.elementPanel != null;
			VisualElementAnimationSystem visualElementAnimationSystem;
			if (flag)
			{
				visualElementAnimationSystem = this.elementPanel.GetUpdater(VisualTreeUpdatePhase.Animation).TryCast<VisualElementAnimationSystem>();
			}
			else
			{
				visualElementAnimationSystem = null;
			}
			return visualElementAnimationSystem;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003869 File Offset: 0x00001A69
		public void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00003876 File Offset: 0x00001A76
		public void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003883 File Offset: 0x00001A83
		public void UnregisterRunningAnimations()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00003890 File Offset: 0x00001A90
		public void RegisterRunningAnimations()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00009D34 File Offset: 0x00007F34
		public IExperimentalFeatures experimental
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00009D48 File Offset: 0x00007F48
		public UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000389D File Offset: 0x00001A9D
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000038AA File Offset: 0x00001AAA
		public bool cacheAsBitmap
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

		// Token: 0x06000223 RID: 547 RVA: 0x000038B7 File Offset: 0x00001AB7
		public bool ShouldClip()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000038C4 File Offset: 0x00001AC4
		public VisualElement parent
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000038D1 File Offset: 0x00001AD1
		// (set) Token: 0x06000226 RID: 550 RVA: 0x000038DE File Offset: 0x00001ADE
		public BaseVisualElementPanel elementPanel
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00009D5C File Offset: 0x00007F5C
		public IPanel panel
		{
			get
			{
				return this.elementPanel;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00009D74 File Offset: 0x00007F74
		public virtual VisualElement contentContainer
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000038EB File Offset: 0x00001AEB
		public void Add(VisualElement child)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000038F8 File Offset: 0x00001AF8
		public void Insert(int index, VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00003905 File Offset: 0x00001B05
		public void Remove(VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00003912 File Offset: 0x00001B12
		public void RemoveAt(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000391F File Offset: 0x00001B1F
		public void Clear()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00009D88 File Offset: 0x00007F88
		public VisualElement ElementAt(int index)
		{
			return this.get_Item(index);
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000392C File Offset: 0x00001B2C
		public VisualElement Item
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00003939 File Offset: 0x00001B39
		public int childCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00003946 File Offset: 0x00001B46
		public int IndexOf(VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00003953 File Offset: 0x00001B53
		public VisualElement ElementAtTreePath(List<int> childIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00003960 File Offset: 0x00001B60
		public bool FindElementInTree(VisualElement element, List<int> outChildIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000396D File Offset: 0x00001B6D
		public IEnumerable<VisualElement> Children()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000397A File Offset: 0x00001B7A
		public void Sort(Comparison<VisualElement> comp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00003987 File Offset: 0x00001B87
		public void BringToFront()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00003994 File Offset: 0x00001B94
		public void SendToBack()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000039A1 File Offset: 0x00001BA1
		public void PlaceBehind(VisualElement sibling)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000039AE File Offset: 0x00001BAE
		public void PlaceInFront(VisualElement sibling)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000039BB File Offset: 0x00001BBB
		public void RemoveFromHierarchy()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00009DA4 File Offset: 0x00007FA4
		public T GetFirstOfType<T>() where T : class
		{
			T t = base.TryCast<T>().Cast<T>();
			bool flag = t != null;
			T t2;
			if (flag)
			{
				t2 = t;
			}
			else
			{
				t2 = this.GetFirstAncestorOfType<T>();
			}
			return t2;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000039C8 File Offset: 0x00001BC8
		public T GetFirstAncestorOfType<T>() where T : class
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000039D5 File Offset: 0x00001BD5
		public bool Contains(VisualElement child)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000039E2 File Offset: 0x00001BE2
		public void GatherAllChildren(List<VisualElement> elements)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000039EF File Offset: 0x00001BEF
		public VisualElement FindCommonAncestor(VisualElement other)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000039FC File Offset: 0x00001BFC
		public VisualElement GetRoot()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003A09 File Offset: 0x00001C09
		public VisualElement GetNextElementDepthFirst()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003A16 File Offset: 0x00001C16
		public VisualElement GetPreviousElementDepthFirst()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00003A23 File Offset: 0x00001C23
		public VisualElement RetargetElement(VisualElement retargetAgainst)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00009DDC File Offset: 0x00007FDC
		public IVisualElementScheduler schedule
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00003A30 File Offset: 0x00001C30
		public IStyle style
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00003A3D File Offset: 0x00001C3D
		public ICustomStyle customStyle
		{
			get
			{
				return this.computedStyle;
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00003A45 File Offset: 0x00001C45
		public void AddStyleSheetPath(string sheetPath)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00003A52 File Offset: 0x00001C52
		public bool HasStyleSheetPath(string sheetPath)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00003A5F File Offset: 0x00001C5F
		public void RemoveStyleSheetPath(string sheetPath)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00003A6C File Offset: 0x00001C6C
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00003A79 File Offset: 0x00001C79
		public string tooltip
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

		// Token: 0x0600024C RID: 588 RVA: 0x00009DF0 File Offset: 0x00007FF0
		public static void OnTooltip(TooltipEvent e)
		{
			VisualElement visualElement = e.currentTarget.TryCast<VisualElement>();
			bool flag = visualElement != null && !String.IsNullOrEmpty(visualElement.tooltip);
			if (flag)
			{
				e.rect = visualElement.worldBound;
				e.tooltip = visualElement.tooltip;
				e.StopImmediatePropagation();
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00003A86 File Offset: 0x00001C86
		public VisualElement.TypeData typeData
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00003A93 File Offset: 0x00001C93
		public IResolvedStyle resolvedStyle
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00003A96 File Offset: 0x00001C96
		public Align UnityEngine.UIElements.IResolvedStyle.alignContent
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00003AA3 File Offset: 0x00001CA3
		public Align UnityEngine.UIElements.IResolvedStyle.alignItems
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00003AB0 File Offset: 0x00001CB0
		public Align UnityEngine.UIElements.IResolvedStyle.alignSelf
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00009E48 File Offset: 0x00008048
		public Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
		{
			get
			{
				return this.computedStyle.backgroundColor.value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00009E68 File Offset: 0x00008068
		public Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
		{
			get
			{
				return this.computedStyle.borderBottomColor.value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00003ABD File Offset: 0x00001CBD
		public float UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00003ACA File Offset: 0x00001CCA
		public float UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00003AD7 File Offset: 0x00001CD7
		public float UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00009E88 File Offset: 0x00008088
		public Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
		{
			get
			{
				return this.computedStyle.borderLeftColor.value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public float UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00009EA8 File Offset: 0x000080A8
		public Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
		{
			get
			{
				return this.computedStyle.borderRightColor.value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00003AF1 File Offset: 0x00001CF1
		public float UnityEngine.UIElements.IResolvedStyle.borderRightWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00009EC8 File Offset: 0x000080C8
		public Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
		{
			get
			{
				return this.computedStyle.borderTopColor.value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00003AFE File Offset: 0x00001CFE
		public float UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00003B0B File Offset: 0x00001D0B
		public float UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00003B18 File Offset: 0x00001D18
		public float UnityEngine.UIElements.IResolvedStyle.borderTopWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00003B25 File Offset: 0x00001D25
		public float UnityEngine.UIElements.IResolvedStyle.bottom
		{
			get
			{
				return this.yogaNode.LayoutBottom;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00009EE8 File Offset: 0x000080E8
		public Color UnityEngine.UIElements.IResolvedStyle.color
		{
			get
			{
				return this.computedStyle.color.value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00003B32 File Offset: 0x00001D32
		public DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00003B3F File Offset: 0x00001D3F
		public FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00003B4C File Offset: 0x00001D4C
		public float UnityEngine.UIElements.IResolvedStyle.flexGrow
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00003B59 File Offset: 0x00001D59
		public float UnityEngine.UIElements.IResolvedStyle.flexShrink
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00003B66 File Offset: 0x00001D66
		public Wrap UnityEngine.UIElements.IResolvedStyle.flexWrap
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00003B73 File Offset: 0x00001D73
		public float UnityEngine.UIElements.IResolvedStyle.fontSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00003B80 File Offset: 0x00001D80
		public float UnityEngine.UIElements.IResolvedStyle.height
		{
			get
			{
				return this.yogaNode.LayoutHeight;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00003B8D File Offset: 0x00001D8D
		public Justify UnityEngine.UIElements.IResolvedStyle.justifyContent
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00003B9A File Offset: 0x00001D9A
		public float UnityEngine.UIElements.IResolvedStyle.left
		{
			get
			{
				return this.yogaNode.LayoutX;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00003BA7 File Offset: 0x00001DA7
		public float UnityEngine.UIElements.IResolvedStyle.marginBottom
		{
			get
			{
				return this.yogaNode.LayoutMarginBottom;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public float UnityEngine.UIElements.IResolvedStyle.marginLeft
		{
			get
			{
				return this.yogaNode.LayoutMarginLeft;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00003BC1 File Offset: 0x00001DC1
		public float UnityEngine.UIElements.IResolvedStyle.marginRight
		{
			get
			{
				return this.yogaNode.LayoutMarginRight;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00003BCE File Offset: 0x00001DCE
		public float UnityEngine.UIElements.IResolvedStyle.marginTop
		{
			get
			{
				return this.yogaNode.LayoutMarginTop;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00003BDB File Offset: 0x00001DDB
		public float UnityEngine.UIElements.IResolvedStyle.opacity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public float UnityEngine.UIElements.IResolvedStyle.paddingBottom
		{
			get
			{
				return this.yogaNode.LayoutPaddingBottom;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00003BF5 File Offset: 0x00001DF5
		public float UnityEngine.UIElements.IResolvedStyle.paddingLeft
		{
			get
			{
				return this.yogaNode.LayoutPaddingLeft;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00003C02 File Offset: 0x00001E02
		public float UnityEngine.UIElements.IResolvedStyle.paddingRight
		{
			get
			{
				return this.yogaNode.LayoutPaddingRight;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00003C0F File Offset: 0x00001E0F
		public float UnityEngine.UIElements.IResolvedStyle.paddingTop
		{
			get
			{
				return this.yogaNode.LayoutPaddingTop;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00003C1C File Offset: 0x00001E1C
		public Position UnityEngine.UIElements.IResolvedStyle.position
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00003C29 File Offset: 0x00001E29
		public float UnityEngine.UIElements.IResolvedStyle.right
		{
			get
			{
				return this.yogaNode.LayoutRight;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00003C36 File Offset: 0x00001E36
		public TextOverflow UnityEngine.UIElements.IResolvedStyle.textOverflow
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00003C43 File Offset: 0x00001E43
		public float UnityEngine.UIElements.IResolvedStyle.top
		{
			get
			{
				return this.yogaNode.LayoutY;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00009F08 File Offset: 0x00008108
		public Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
		{
			get
			{
				return this.computedStyle.unityBackgroundImageTintColor.value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00003C50 File Offset: 0x00001E50
		public ScaleMode UnityEngine.UIElements.IResolvedStyle.unityBackgroundScaleMode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00003C5D File Offset: 0x00001E5D
		public Font UnityEngine.UIElements.IResolvedStyle.unityFont
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00003C6A File Offset: 0x00001E6A
		public FontStyle UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00003C77 File Offset: 0x00001E77
		public int UnityEngine.UIElements.IResolvedStyle.unitySliceBottom
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00003C84 File Offset: 0x00001E84
		public int UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00003C91 File Offset: 0x00001E91
		public int UnityEngine.UIElements.IResolvedStyle.unitySliceRight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00003C9E File Offset: 0x00001E9E
		public int UnityEngine.UIElements.IResolvedStyle.unitySliceTop
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00003CAB File Offset: 0x00001EAB
		public TextAnchor UnityEngine.UIElements.IResolvedStyle.unityTextAlign
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00003CC5 File Offset: 0x00001EC5
		public Visibility UnityEngine.UIElements.IResolvedStyle.visibility
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00003CD2 File Offset: 0x00001ED2
		public WhiteSpace UnityEngine.UIElements.IResolvedStyle.whiteSpace
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00003CDF File Offset: 0x00001EDF
		public float UnityEngine.UIElements.IResolvedStyle.width
		{
			get
			{
				return this.yogaNode.LayoutWidth;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003CEC File Offset: 0x00001EEC
		public YogaSize <AssignMeasureFunction>b__202_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode)
		{
			return this.Measure(node, f, mode, f1, heightMode);
		}

		// Token: 0x020001B3 RID: 435
		public class UxmlFactory : UxmlFactory<VisualElement, VisualElement.UxmlTraits>
		{
		}

		// Token: 0x020001B4 RID: 436
		public class UxmlTraits : UnityEngine.UIElements.UxmlTraits
		{
			// Token: 0x0200021F RID: 543
			public sealed class <get_uxmlChildElementsDescription>d__18
			{
			}
		}

		// Token: 0x020001B5 RID: 437
		public enum MeasureMode
		{
			// Token: 0x04000231 RID: 561
			Undefined,
			// Token: 0x04000232 RID: 562
			Exactly,
			// Token: 0x04000233 RID: 563
			AtMost
		}

		// Token: 0x020001B6 RID: 438
		public abstract class BaseVisualElementScheduledItem : ScheduledItem
		{
		}

		// Token: 0x020001B7 RID: 439
		public class TimerStateScheduledItem : VisualElement.VisualElementScheduledItem<Action<TimerState>>
		{
		}

		// Token: 0x020001B8 RID: 440
		public class SimpleScheduledItem : VisualElement.VisualElementScheduledItem<Action>
		{
		}

		// Token: 0x020001B9 RID: 441
		public class TypeData
		{
		}

		// Token: 0x020001BA RID: 442
		public sealed class <>c__DisplayClass234_0
		{
		}

		// Token: 0x020001BB RID: 443
		public sealed class <>c__DisplayClass235_0
		{
		}

		// Token: 0x020001BC RID: 444
		public sealed class <>c__DisplayClass236_0
		{
		}

		// Token: 0x020001BD RID: 445
		public sealed class <>c__DisplayClass237_0
		{
		}

		// Token: 0x020001BE RID: 446
		public sealed class <>c__DisplayClass238_0
		{
		}

		// Token: 0x020001BF RID: 447
		public sealed class <>c__DisplayClass239_0
		{
		}

		// Token: 0x020001C0 RID: 448
		public sealed class <>c__DisplayClass240_0
		{
		}

		// Token: 0x020001C1 RID: 449
		public sealed class <>c__DisplayClass250_0
		{
		}

		// Token: 0x020001C2 RID: 450
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
