using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200017C RID: 380
	public class ScreenShaker : MonoBehaviour
	{
		// Token: 0x06002D39 RID: 11577 RVA: 0x000B0FA0 File Offset: 0x000AF1A0
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenShaker()
		{
			Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScreenShaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr);
			ScreenShaker.NativeFieldInfoPtr_shakeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr, "shakeTime");
			ScreenShaker.NativeFieldInfoPtr_shakeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr, "shakeTimer");
			ScreenShaker.NativeFieldInfoPtr_shakeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr, "shakeAmount");
			ScreenShaker.NativeFieldInfoPtr_shaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr, "shaking");
			ScreenShaker.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr, 100666813);
			ScreenShaker.NativeMethodInfoPtr__ctor_Private_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr, 100666814);
			ScreenShaker.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr, 100666815);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000B105C File Offset: 0x000AF25C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenShaker.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x000B1090 File Offset: 0x000AF290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81094, XrefRangeEnd = 81097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenShaker(Vector2 amount, float time)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenShaker>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenShaker.NativeMethodInfoPtr__ctor_Private_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x000B10E8 File Offset: 0x000AF2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81097, XrefRangeEnd = 81109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenShaker.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x0001F4F4 File Offset: 0x0001D6F4
		public ScreenShaker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000B111C File Offset: 0x000AF31C
		// (set) Token: 0x06002D3F RID: 11583 RVA: 0x0001F4FD File Offset: 0x0001D6FD
		public unsafe float shakeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenShaker.NativeFieldInfoPtr_shakeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenShaker.NativeFieldInfoPtr_shakeTime)) = value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000B1144 File Offset: 0x000AF344
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x0001F518 File Offset: 0x0001D718
		public unsafe float shakeTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenShaker.NativeFieldInfoPtr_shakeTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenShaker.NativeFieldInfoPtr_shakeTimer)) = value;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x000B116C File Offset: 0x000AF36C
		// (set) Token: 0x06002D43 RID: 11587 RVA: 0x0001F533 File Offset: 0x0001D733
		public unsafe Vector2 shakeAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenShaker.NativeFieldInfoPtr_shakeAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenShaker.NativeFieldInfoPtr_shakeAmount)) = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x000B1194 File Offset: 0x000AF394
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x0001F54E File Offset: 0x0001D74E
		public unsafe bool shaking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenShaker.NativeFieldInfoPtr_shaking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenShaker.NativeFieldInfoPtr_shaking)) = value;
			}
		}

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeFieldInfoPtr_shakeTime;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeFieldInfoPtr_shakeTimer;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeFieldInfoPtr_shakeAmount;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeFieldInfoPtr_shaking;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Vector2_Single_0;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;
	}
}
