using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000A1 RID: 161
	public class Car : Throwable
	{
		// Token: 0x060013D2 RID: 5074 RVA: 0x0006C8B4 File Offset: 0x0006AAB4
		// Note: this type is marked as 'beforefieldinit'.
		static Car()
		{
			Il2CppClassPointerStore<Car>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Car");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Car>.NativeClassPtr);
			Car.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "health");
			Car.NativeFieldInfoPtr_prevPushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "prevPushed");
			Car.NativeFieldInfoPtr_obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "obstacle");
			Car.NativeFieldInfoPtr_botRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "botRend");
			Car.NativeFieldInfoPtr_botMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "botMesh");
			Car.NativeFieldInfoPtr_topMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "topMesh");
			Car.NativeFieldInfoPtr_shadowMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "shadowMesh");
			Car.NativeFieldInfoPtr_shadowVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "shadowVerts");
			Car.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "tris");
			Car.NativeFieldInfoPtr_paralaxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "paralaxAmount");
			Car.NativeFieldInfoPtr_defTopPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Car>.NativeClassPtr, "defTopPos");
			Car.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664978);
			Car.NativeMethodInfoPtr_InitMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664979);
			Car.NativeMethodInfoPtr_GetTopVert_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664980);
			Car.NativeMethodInfoPtr_GetBotVert_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664981);
			Car.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664982);
			Car.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664983);
			Car.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664984);
			Car.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664985);
			Car.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664986);
			Car.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664987);
			Car.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Car>.NativeClassPtr, 100664988);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0006CA9C File Offset: 0x0006AC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51783, XrefRangeEnd = 51790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Car.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0006CAD0 File Offset: 0x0006ACD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51790, XrefRangeEnd = 51918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Car.NativeMethodInfoPtr_InitMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0006CB04 File Offset: 0x0006AD04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 51930, RefRangeEnd = 51933, XrefRangeStart = 51918, XrefRangeEnd = 51930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTopVert(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Car.NativeMethodInfoPtr_GetTopVert_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0006CB50 File Offset: 0x0006AD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51933, XrefRangeEnd = 51937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBotVert(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Car.NativeMethodInfoPtr_GetBotVert_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0006CB9C File Offset: 0x0006AD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51937, XrefRangeEnd = 51955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Car.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0006CBD0 File Offset: 0x0006ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51955, XrefRangeEnd = 51962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> bla)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bla);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Car.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0006CC20 File Offset: 0x0006AE20
		[CallerCount(0)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Car.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0006CC6C File Offset: 0x0006AE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51962, XrefRangeEnd = 51975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Car.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0006CCA0 File Offset: 0x0006AEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51975, XrefRangeEnd = 51980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPushed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Car.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0006CCEC File Offset: 0x0006AEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51980, XrefRangeEnd = 51994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCollisionEnter2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Car.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_Void_Collision2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0006CD3C File Offset: 0x0006AF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Car()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Car>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Car.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0000E858 File Offset: 0x0000CA58
		public Car(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0006CD78 File Offset: 0x0006AF78
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x0000E861 File Offset: 0x0000CA61
		public unsafe int health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_health)) = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0006CDA0 File Offset: 0x0006AFA0
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x0000E87C File Offset: 0x0000CA7C
		public unsafe bool prevPushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_prevPushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_prevPushed)) = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0006CDC8 File Offset: 0x0006AFC8
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0000E897 File Offset: 0x0000CA97
		public unsafe Obstacle obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Obstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0006CDF8 File Offset: 0x0006AFF8
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x0000E8B6 File Offset: 0x0000CAB6
		public unsafe MeshRenderer botRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_botRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_botRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0006CE28 File Offset: 0x0006B028
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x0000E8D5 File Offset: 0x0000CAD5
		public unsafe MeshFilter botMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_botMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_botMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x0006CE58 File Offset: 0x0006B058
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		public unsafe MeshFilter topMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_topMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_topMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0006CE88 File Offset: 0x0006B088
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x0000E913 File Offset: 0x0000CB13
		public unsafe MeshFilter shadowMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_shadowMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_shadowMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0006CEB8 File Offset: 0x0006B0B8
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x0000E932 File Offset: 0x0000CB32
		public unsafe Il2CppStructArray<Vector3> shadowVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_shadowVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_shadowVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0006CEE8 File Offset: 0x0006B0E8
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x0000E951 File Offset: 0x0000CB51
		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_tris);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_tris), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0006CF18 File Offset: 0x0006B118
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x0000E970 File Offset: 0x0000CB70
		public unsafe float paralaxAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_paralaxAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_paralaxAmount)) = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0006CF40 File Offset: 0x0006B140
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x0000E98B File Offset: 0x0000CB8B
		public unsafe Vector2 defTopPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_defTopPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Car.NativeFieldInfoPtr_defTopPos)) = value;
			}
		}

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeFieldInfoPtr_health;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeFieldInfoPtr_prevPushed;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeFieldInfoPtr_obstacle;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeFieldInfoPtr_botRend;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeFieldInfoPtr_botMesh;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeFieldInfoPtr_topMesh;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr_shadowMesh;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr_shadowVerts;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeFieldInfoPtr_paralaxAmount;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_defTopPos;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_InitMesh_Public_Void_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_GetTopVert_Private_Int32_Int32_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_GetBotVert_Private_Int32_Int32_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_Void_Collision2D_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
