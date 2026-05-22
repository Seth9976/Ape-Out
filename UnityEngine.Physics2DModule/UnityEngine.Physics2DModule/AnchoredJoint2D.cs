using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public class AnchoredJoint2D : Joint2D
	{
		// Token: 0x0600034D RID: 845 RVA: 0x0000D278 File Offset: 0x0000B478
		// Note: this type is marked as 'beforefieldinit'.
		static AnchoredJoint2D()
		{
			Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "AnchoredJoint2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr);
			AnchoredJoint2D.NativeMethodInfoPtr_set_connectedAnchor_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr, 100663449);
			AnchoredJoint2D.NativeMethodInfoPtr_set_connectedAnchor_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr, 100663450);
			AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegate>("UnityEngine.AnchoredJoint2D::get_autoConfigureConnectedAnchor");
			AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegate>("UnityEngine.AnchoredJoint2D::set_autoConfigureConnectedAnchor");
			AnchoredJoint2D.get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_anchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::get_anchor_Injected");
			AnchoredJoint2D.set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.set_anchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::set_anchor_Injected");
			AnchoredJoint2D.get_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_connectedAnchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::get_connectedAnchor_Injected");
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000D3B4 File Offset: 0x0000B5B4
		// (set) Token: 0x0600034E RID: 846 RVA: 0x0000D31C File Offset: 0x0000B51C
		public unsafe Vector2 connectedAnchor
		{
			get
			{
				Vector2 vector;
				this.get_connectedAnchor_Injected(out vector);
				return vector;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 513501, RefRangeEnd = 513503, XrefRangeStart = 513499, XrefRangeEnd = 513501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchoredJoint2D.NativeMethodInfoPtr_set_connectedAnchor_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000D35C File Offset: 0x0000B55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513503, XrefRangeEnd = 513507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_connectedAnchor_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchoredJoint2D.NativeMethodInfoPtr_set_connectedAnchor_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003617 File Offset: 0x00001817
		public AnchoredJoint2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000D39C File Offset: 0x0000B59C
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00003620 File Offset: 0x00001820
		public Vector2 anchor
		{
			get
			{
				Vector2 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000362A File Offset: 0x0000182A
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0000363C File Offset: 0x0000183C
		public bool autoConfigureConnectedAnchor
		{
			get
			{
				return AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000364F File Offset: 0x0000184F
		public void get_anchor_Injected(out Vector2 ret)
		{
			AnchoredJoint2D.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003662 File Offset: 0x00001862
		public void set_anchor_Injected(ref Vector2 value)
		{
			AnchoredJoint2D.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00003675 File Offset: 0x00001875
		public void get_connectedAnchor_Injected(out Vector2 ret)
		{
			AnchoredJoint2D.get_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_set_connectedAnchor_Public_set_Void_Vector2_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_set_connectedAnchor_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040001E9 RID: 489
		private static readonly AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegate get_autoConfigureConnectedAnchorDelegateField;

		// Token: 0x040001EA RID: 490
		private static readonly AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegate set_autoConfigureConnectedAnchorDelegateField;

		// Token: 0x040001EB RID: 491
		private static readonly AnchoredJoint2D.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField;

		// Token: 0x040001EC RID: 492
		private static readonly AnchoredJoint2D.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField;

		// Token: 0x040001ED RID: 493
		private static readonly AnchoredJoint2D.get_connectedAnchor_InjectedDelegate get_connectedAnchor_InjectedDelegateField;

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x0600061C RID: 1564
		private delegate bool get_autoConfigureConnectedAnchorDelegate(IntPtr @this);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x0600061E RID: 1566
		private delegate void set_autoConfigureConnectedAnchorDelegate(IntPtr @this, bool value);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x06000620 RID: 1568
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x06000622 RID: 1570
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x06000624 RID: 1572
		private delegate void get_connectedAnchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
