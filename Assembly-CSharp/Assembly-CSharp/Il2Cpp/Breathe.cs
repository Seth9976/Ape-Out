using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200008E RID: 142
	public class Breathe : MonoBehaviour
	{
		// Token: 0x06001147 RID: 4423 RVA: 0x00066208 File Offset: 0x00064408
		// Note: this type is marked as 'beforefieldinit'.
		static Breathe()
		{
			Il2CppClassPointerStore<Breathe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Breathe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Breathe>.NativeClassPtr);
			Breathe.NativeFieldInfoPtr_baseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Breathe>.NativeClassPtr, "baseScale");
			Breathe.NativeFieldInfoPtr_peakScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Breathe>.NativeClassPtr, "peakScale");
			Breathe.NativeFieldInfoPtr_rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Breathe>.NativeClassPtr, "rate");
			Breathe.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Breathe>.NativeClassPtr, 100664771);
			Breathe.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Breathe>.NativeClassPtr, 100664772);
			Breathe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Breathe>.NativeClassPtr, 100664773);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x000662B0 File Offset: 0x000644B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Breathe.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000662E4 File Offset: 0x000644E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48970, XrefRangeEnd = 48977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Breathe.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00066318 File Offset: 0x00064518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Breathe()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Breathe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Breathe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0000CB59 File Offset: 0x0000AD59
		public Breathe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00066354 File Offset: 0x00064554
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x0000CB62 File Offset: 0x0000AD62
		public unsafe Vector3 baseScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Breathe.NativeFieldInfoPtr_baseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Breathe.NativeFieldInfoPtr_baseScale)) = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0006637C File Offset: 0x0006457C
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0000CB7D File Offset: 0x0000AD7D
		public unsafe Vector3 peakScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Breathe.NativeFieldInfoPtr_peakScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Breathe.NativeFieldInfoPtr_peakScale)) = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x000663A4 File Offset: 0x000645A4
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x0000CB98 File Offset: 0x0000AD98
		public unsafe float rate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Breathe.NativeFieldInfoPtr_rate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Breathe.NativeFieldInfoPtr_rate)) = value;
			}
		}

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeFieldInfoPtr_baseScale;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr_peakScale;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr_rate;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
