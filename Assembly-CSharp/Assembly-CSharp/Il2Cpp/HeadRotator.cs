using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000109 RID: 265
	public class HeadRotator : MonoBehaviour
	{
		// Token: 0x06001F5F RID: 8031 RVA: 0x0008C61C File Offset: 0x0008A81C
		// Note: this type is marked as 'beforefieldinit'.
		static HeadRotator()
		{
			Il2CppClassPointerStore<HeadRotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HeadRotator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr);
			HeadRotator.NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr, "rot");
			HeadRotator.NativeFieldInfoPtr_oldrot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr, "oldrot");
			HeadRotator.NativeFieldInfoPtr_newrot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr, "newrot");
			HeadRotator.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr, "timer");
			HeadRotator.NativeFieldInfoPtr_maxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr, "maxt");
			HeadRotator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr, 100665798);
			HeadRotator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr, 100665799);
			HeadRotator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr, 100665800);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x0008C6EC File Offset: 0x0008A8EC
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeadRotator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x0008C720 File Offset: 0x0008A920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66416, XrefRangeEnd = 66426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeadRotator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0008C754 File Offset: 0x0008A954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeadRotator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeadRotator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeadRotator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00015EFD File Offset: 0x000140FD
		public HeadRotator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0008C790 File Offset: 0x0008A990
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x00015F06 File Offset: 0x00014106
		public unsafe Vector3 rot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_rot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_rot)) = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0008C7B8 File Offset: 0x0008A9B8
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x00015F21 File Offset: 0x00014121
		public unsafe float oldrot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_oldrot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_oldrot)) = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0008C7E0 File Offset: 0x0008A9E0
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00015F3C File Offset: 0x0001413C
		public unsafe float newrot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_newrot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_newrot)) = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0008C808 File Offset: 0x0008AA08
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00015F57 File Offset: 0x00014157
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0008C830 File Offset: 0x0008AA30
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x00015F72 File Offset: 0x00014172
		public unsafe float maxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_maxt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadRotator.NativeFieldInfoPtr_maxt)) = value;
			}
		}

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeFieldInfoPtr_rot;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeFieldInfoPtr_oldrot;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeFieldInfoPtr_newrot;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeFieldInfoPtr_maxt;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
