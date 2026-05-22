using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000A2 RID: 162
	public class CarSpawner : MonoBehaviour
	{
		// Token: 0x060013F5 RID: 5109 RVA: 0x0006CF68 File Offset: 0x0006B168
		// Note: this type is marked as 'beforefieldinit'.
		static CarSpawner()
		{
			Il2CppClassPointerStore<CarSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CarSpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarSpawner>.NativeClassPtr);
			CarSpawner.NativeFieldInfoPtr_car = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSpawner>.NativeClassPtr, "car");
			CarSpawner.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSpawner>.NativeClassPtr, 100664989);
			CarSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSpawner>.NativeClassPtr, 100664990);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0006CFD4 File Offset: 0x0006B1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51994, XrefRangeEnd = 52027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarSpawner.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0006D008 File Offset: 0x0006B208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarSpawner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarSpawner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0000E9A6 File Offset: 0x0000CBA6
		public CarSpawner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0006D044 File Offset: 0x0006B244
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x0000E9AF File Offset: 0x0000CBAF
		public unsafe GameObject car
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarSpawner.NativeFieldInfoPtr_car);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarSpawner.NativeFieldInfoPtr_car), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeFieldInfoPtr_car;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
