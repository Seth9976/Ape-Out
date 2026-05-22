using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001B9 RID: 441
	public class StreetCar : MonoBehaviour
	{
		// Token: 0x060030FD RID: 12541 RVA: 0x000BB34C File Offset: 0x000B954C
		// Note: this type is marked as 'beforefieldinit'.
		static StreetCar()
		{
			Il2CppClassPointerStore<StreetCar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StreetCar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetCar>.NativeClassPtr);
			StreetCar.NativeFieldInfoPtr_spd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCar>.NativeClassPtr, "spd");
			StreetCar.NativeFieldInfoPtr_goVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCar>.NativeClassPtr, "goVect");
			StreetCar.NativeFieldInfoPtr_startx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCar>.NativeClassPtr, "startx");
			StreetCar.NativeFieldInfoPtr_flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCar>.NativeClassPtr, "flip");
			StreetCar.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetCar>.NativeClassPtr, 100667138);
			StreetCar.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetCar>.NativeClassPtr, 100667139);
			StreetCar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetCar>.NativeClassPtr, 100667140);
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x000BB408 File Offset: 0x000B9608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84847, XrefRangeEnd = 84861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetCar.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000BB43C File Offset: 0x000B963C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84861, XrefRangeEnd = 84881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetCar.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000BB470 File Offset: 0x000B9670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetCar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetCar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetCar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000219ED File Offset: 0x0001FBED
		public StreetCar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x000BB4AC File Offset: 0x000B96AC
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x000219F6 File Offset: 0x0001FBF6
		public unsafe float spd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetCar.NativeFieldInfoPtr_spd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetCar.NativeFieldInfoPtr_spd)) = value;
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x000BB4D4 File Offset: 0x000B96D4
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x00021A11 File Offset: 0x0001FC11
		public unsafe Vector3 goVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetCar.NativeFieldInfoPtr_goVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetCar.NativeFieldInfoPtr_goVect)) = value;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x000BB4FC File Offset: 0x000B96FC
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x00021A2C File Offset: 0x0001FC2C
		public unsafe float startx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetCar.NativeFieldInfoPtr_startx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetCar.NativeFieldInfoPtr_startx)) = value;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x000BB524 File Offset: 0x000B9724
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x00021A47 File Offset: 0x0001FC47
		public unsafe bool flip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetCar.NativeFieldInfoPtr_flip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetCar.NativeFieldInfoPtr_flip)) = value;
			}
		}

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeFieldInfoPtr_spd;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeFieldInfoPtr_goVect;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeFieldInfoPtr_startx;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeFieldInfoPtr_flip;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
