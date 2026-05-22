using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000068 RID: 104
	public class AmbientCar : MonoBehaviour
	{
		// Token: 0x06000E15 RID: 3605 RVA: 0x0005DAD4 File Offset: 0x0005BCD4
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientCar()
		{
			Il2CppClassPointerStore<AmbientCar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmbientCar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr);
			AmbientCar.NativeFieldInfoPtr_cars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr, "cars");
			AmbientCar.NativeFieldInfoPtr_carSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr, "carSpeed");
			AmbientCar.NativeFieldInfoPtr_streetRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr, "streetRenderer");
			AmbientCar.NativeFieldInfoPtr_streetBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr, "streetBounds");
			AmbientCar.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr, "width");
			AmbientCar.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr, 100664497);
			AmbientCar.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr, 100664498);
			AmbientCar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr, 100664499);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0005DBA4 File Offset: 0x0005BDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44768, XrefRangeEnd = 44770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientCar.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0005DBD8 File Offset: 0x0005BDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44770, XrefRangeEnd = 44804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientCar.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0005DC0C File Offset: 0x0005BE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientCar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientCar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientCar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0000AB0C File Offset: 0x00008D0C
		public AmbientCar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0005DC48 File Offset: 0x0005BE48
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x0000AB15 File Offset: 0x00008D15
		public unsafe List<GameObject> cars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_cars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_cars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0005DC78 File Offset: 0x0005BE78
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x0000AB34 File Offset: 0x00008D34
		public unsafe float carSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_carSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_carSpeed)) = value;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x0005DCA0 File Offset: 0x0005BEA0
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x0000AB4F File Offset: 0x00008D4F
		public unsafe MeshRenderer streetRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_streetRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_streetRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0005DCD0 File Offset: 0x0005BED0
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x0000AB6E File Offset: 0x00008D6E
		public unsafe Bounds streetBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_streetBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_streetBounds)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0005DCF8 File Offset: 0x0005BEF8
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x0000AB89 File Offset: 0x00008D89
		public unsafe Vector3 width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientCar.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_cars;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeFieldInfoPtr_carSpeed;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeFieldInfoPtr_streetRenderer;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeFieldInfoPtr_streetBounds;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
