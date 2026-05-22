using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000133 RID: 307
	public class Mover : MonoBehaviour
	{
		// Token: 0x0600262A RID: 9770 RVA: 0x0009E400 File Offset: 0x0009C600
		// Note: this type is marked as 'beforefieldinit'.
		static Mover()
		{
			Il2CppClassPointerStore<Mover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Mover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mover>.NativeClassPtr);
			Mover.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "myPos");
			Mover.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "pos");
			Mover.NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "rot");
			Mover.NativeFieldInfoPtr_lastZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "lastZ");
			Mover.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "init");
			Mover.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "rb");
			Mover.NativeFieldInfoPtr_prevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "prevPos");
			Mover.NativeFieldInfoPtr_posDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "posDelta");
			Mover.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mover>.NativeClassPtr, "trans");
			Mover.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666337);
			Mover.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666338);
			Mover.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666339);
			Mover.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666340);
			Mover.NativeMethodInfoPtr_SetPos_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666341);
			Mover.NativeMethodInfoPtr_SetRot_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666342);
			Mover.NativeMethodInfoPtr_AddPos_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666343);
			Mover.NativeMethodInfoPtr_AddRot_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666344);
			Mover.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666345);
			Mover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mover>.NativeClassPtr, 100666346);
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x0009E5AC File Offset: 0x0009C7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74260, XrefRangeEnd = 74274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x0009E5E0 File Offset: 0x0009C7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74274, XrefRangeEnd = 74287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x0009E614 File Offset: 0x0009C814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74287, XrefRangeEnd = 74296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0009E648 File Offset: 0x0009C848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74296, XrefRangeEnd = 74306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0009E67C File Offset: 0x0009C87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74306, XrefRangeEnd = 74307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPos(Vector2 a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_SetPos_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x0009E6BC File Offset: 0x0009C8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74307, XrefRangeEnd = 74308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRot(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_SetRot_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x0009E6FC File Offset: 0x0009C8FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 74309, RefRangeEnd = 74314, XrefRangeStart = 74308, XrefRangeEnd = 74309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPos(Vector2 a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_AddPos_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x0009E73C File Offset: 0x0009C93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74314, XrefRangeEnd = 74315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRot(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_AddRot_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x0009E77C File Offset: 0x0009C97C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 74320, RefRangeEnd = 74350, XrefRangeStart = 74315, XrefRangeEnd = 74320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x0009E7B0 File Offset: 0x0009C9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mover()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x0001AAFE File Offset: 0x00018CFE
		public Mover(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x0009E7EC File Offset: 0x0009C9EC
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x0001AB07 File Offset: 0x00018D07
		public unsafe Vector2 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x0009E814 File Offset: 0x0009CA14
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x0001AB22 File Offset: 0x00018D22
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x0009E83C File Offset: 0x0009CA3C
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x0001AB3D File Offset: 0x00018D3D
		public unsafe float rot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_rot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_rot)) = value;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x0009E864 File Offset: 0x0009CA64
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x0001AB58 File Offset: 0x00018D58
		public unsafe float lastZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_lastZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_lastZ)) = value;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x0009E88C File Offset: 0x0009CA8C
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x0001AB73 File Offset: 0x00018D73
		public unsafe bool init
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_init);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_init)) = value;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x0009E8B4 File Offset: 0x0009CAB4
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x0001AB8E File Offset: 0x00018D8E
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x0009E8E4 File Offset: 0x0009CAE4
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x0001ABAD File Offset: 0x00018DAD
		public unsafe Vector2 prevPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_prevPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_prevPos)) = value;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x0009E90C File Offset: 0x0009CB0C
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		public unsafe Vector2 posDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_posDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_posDelta)) = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x0009E934 File Offset: 0x0009CB34
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x0001ABE3 File Offset: 0x00018DE3
		public unsafe Transform trans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_trans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mover.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_rot;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeFieldInfoPtr_lastZ;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeFieldInfoPtr_init;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeFieldInfoPtr_prevPos;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeFieldInfoPtr_posDelta;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeFieldInfoPtr_trans;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr_SetPos_Public_Void_Vector2_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr_SetRot_Public_Void_Single_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr_AddPos_Public_Void_Vector2_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_AddRot_Public_Void_Single_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
