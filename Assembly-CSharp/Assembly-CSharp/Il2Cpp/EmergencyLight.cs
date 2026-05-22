using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C2 RID: 194
	public class EmergencyLight : MonoBehaviour
	{
		// Token: 0x060016E9 RID: 5865 RVA: 0x00074E40 File Offset: 0x00073040
		// Note: this type is marked as 'beforefieldinit'.
		static EmergencyLight()
		{
			Il2CppClassPointerStore<EmergencyLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EmergencyLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmergencyLight>.NativeClassPtr);
			EmergencyLight.NativeFieldInfoPtr_trigged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmergencyLight>.NativeClassPtr, "trigged");
			EmergencyLight.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmergencyLight>.NativeClassPtr, "lights");
			EmergencyLight.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmergencyLight>.NativeClassPtr, 100665212);
			EmergencyLight.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmergencyLight>.NativeClassPtr, 100665213);
			EmergencyLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmergencyLight>.NativeClassPtr, 100665214);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00074ED4 File Offset: 0x000730D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56280, XrefRangeEnd = 56311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmergencyLight.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00074F08 File Offset: 0x00073108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56311, XrefRangeEnd = 56353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmergencyLight.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00074F3C File Offset: 0x0007313C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmergencyLight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmergencyLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmergencyLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0001079D File Offset: 0x0000E99D
		public EmergencyLight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00074F78 File Offset: 0x00073178
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x000107A6 File Offset: 0x0000E9A6
		public unsafe bool trigged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmergencyLight.NativeFieldInfoPtr_trigged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmergencyLight.NativeFieldInfoPtr_trigged)) = value;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00074FA0 File Offset: 0x000731A0
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x000107C1 File Offset: 0x0000E9C1
		public unsafe Il2CppReferenceArray<FlashLight> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmergencyLight.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FlashLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmergencyLight.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr_trigged;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
