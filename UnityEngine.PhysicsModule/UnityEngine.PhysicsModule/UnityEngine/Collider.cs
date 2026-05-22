using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public class Collider : Component
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00005BAC File Offset: 0x00003DAC
		// Note: this type is marked as 'beforefieldinit'.
		static Collider()
		{
			Il2CppClassPointerStore<Collider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Collider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collider>.NativeClassPtr);
			Collider.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663329);
			Collider.NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663330);
			Collider.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663331);
			Collider.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663332);
			Collider.NativeMethodInfoPtr_get_sharedMaterial_Public_get_PhysicMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663333);
			Collider.NativeMethodInfoPtr_get_material_Public_get_PhysicMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663334);
			Collider.NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663335);
			Collider.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663336);
			Collider.NativeMethodInfoPtr_Internal_ClosestPointOnBounds_Private_Void_Vector3_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663337);
			Collider.NativeMethodInfoPtr_ClosestPointOnBounds_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663338);
			Collider.NativeMethodInfoPtr_ClosestPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663339);
			Collider.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663340);
			Collider.NativeMethodInfoPtr_Raycast_Injected_Private_Void_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663341);
			Collider.NativeMethodInfoPtr_Internal_ClosestPointOnBounds_Injected_Private_Void_byref_Vector3_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663342);
			Collider.set_enabledDelegateField = IL2CPP.ResolveICall<Collider.set_enabledDelegate>("UnityEngine.Collider::set_enabled");
			Collider.get_attachedArticulationBodyDelegateField = IL2CPP.ResolveICall<Collider.get_attachedArticulationBodyDelegate>("UnityEngine.Collider::get_attachedArticulationBody");
			Collider.get_isTriggerDelegateField = IL2CPP.ResolveICall<Collider.get_isTriggerDelegate>("UnityEngine.Collider::get_isTrigger");
			Collider.set_isTriggerDelegateField = IL2CPP.ResolveICall<Collider.set_isTriggerDelegate>("UnityEngine.Collider::set_isTrigger");
			Collider.get_contactOffsetDelegateField = IL2CPP.ResolveICall<Collider.get_contactOffsetDelegate>("UnityEngine.Collider::get_contactOffset");
			Collider.set_contactOffsetDelegateField = IL2CPP.ResolveICall<Collider.set_contactOffsetDelegate>("UnityEngine.Collider::set_contactOffset");
			Collider.set_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider.set_sharedMaterialDelegate>("UnityEngine.Collider::set_sharedMaterial");
			Collider.set_materialDelegateField = IL2CPP.ResolveICall<Collider.set_materialDelegate>("UnityEngine.Collider::set_material");
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005D6C File Offset: 0x00003F6C
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002928 File Offset: 0x00000B28
		public unsafe bool enabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 513596, RefRangeEnd = 513598, XrefRangeStart = 513592, XrefRangeEnd = 513596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Collider.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005DA8 File Offset: 0x00003FA8
		public unsafe Rigidbody attachedRigidbody
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513598, XrefRangeEnd = 513602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005DE8 File Offset: 0x00003FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513602, XrefRangeEnd = 513604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ClosestPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00005E34 File Offset: 0x00004034
		public unsafe Bounds bounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513604, XrefRangeEnd = 513606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005E70 File Offset: 0x00004070
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002985 File Offset: 0x00000B85
		public unsafe PhysicMaterial sharedMaterial
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 513610, RefRangeEnd = 513613, XrefRangeStart = 513606, XrefRangeEnd = 513610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_sharedMaterial_Public_get_PhysicMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr3) : null;
			}
			set
			{
				Collider.set_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005EB0 File Offset: 0x000040B0
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000299D File Offset: 0x00000B9D
		public unsafe PhysicMaterial material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513613, XrefRangeEnd = 513617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_material_Public_get_PhysicMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr3) : null;
			}
			set
			{
				Collider.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005EF0 File Offset: 0x000040F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513617, XrefRangeEnd = 513619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasHit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005F58 File Offset: 0x00004158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513619, XrefRangeEnd = 513621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005FC0 File Offset: 0x000041C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513621, XrefRangeEnd = 513623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_Internal_ClosestPointOnBounds_Private_Void_Vector3_byref_Vector3_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000601C File Offset: 0x0000421C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513623, XrefRangeEnd = 513627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ClosestPointOnBounds(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_ClosestPointOnBounds_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00006068 File Offset: 0x00004268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513627, XrefRangeEnd = 513631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_ClosestPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000060B4 File Offset: 0x000042B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513631, XrefRangeEnd = 513635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000060F4 File Offset: 0x000042F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513635, XrefRangeEnd = 513639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasHit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_Raycast_Injected_Private_Void_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006160 File Offset: 0x00004360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513639, XrefRangeEnd = 513643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_Internal_ClosestPointOnBounds_Injected_Private_Void_byref_Vector3_byref_Vector3_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000291F File Offset: 0x00000B1F
		public Collider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000061BC File Offset: 0x000043BC
		public ArticulationBody attachedArticulationBody
		{
			get
			{
				IntPtr intPtr = Collider.get_attachedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArticulationBody>(intPtr2) : null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000293B File Offset: 0x00000B3B
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000294D File Offset: 0x00000B4D
		public bool isTrigger
		{
			get
			{
				return Collider.get_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002960 File Offset: 0x00000B60
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002972 File Offset: 0x00000B72
		public float contactOffset
		{
			get
			{
				return Collider.get_contactOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_contactOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_PhysicMaterial_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_PhysicMaterial_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ClosestPointOnBounds_Private_Void_Vector3_byref_Vector3_byref_Single_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPointOnBounds_Public_Vector3_Vector3_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Injected_Private_Void_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ClosestPointOnBounds_Injected_Private_Void_byref_Vector3_byref_Vector3_byref_Single_0;

		// Token: 0x0400009F RID: 159
		private static readonly Collider.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly Collider.get_attachedArticulationBodyDelegate get_attachedArticulationBodyDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly Collider.get_isTriggerDelegate get_isTriggerDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly Collider.set_isTriggerDelegate set_isTriggerDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly Collider.get_contactOffsetDelegate get_contactOffsetDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly Collider.set_contactOffsetDelegate set_contactOffsetDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly Collider.set_sharedMaterialDelegate set_sharedMaterialDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly Collider.set_materialDelegate set_materialDelegateField;

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000400 RID: 1024
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000402 RID: 1026
		private delegate IntPtr get_attachedArticulationBodyDelegate(IntPtr @this);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000404 RID: 1028
		private delegate bool get_isTriggerDelegate(IntPtr @this);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000406 RID: 1030
		private delegate void set_isTriggerDelegate(IntPtr @this, bool value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x06000408 RID: 1032
		private delegate float get_contactOffsetDelegate(IntPtr @this);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x0600040A RID: 1034
		private delegate void set_contactOffsetDelegate(IntPtr @this, float value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x0600040C RID: 1036
		private delegate void set_sharedMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x0600040E RID: 1038
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
