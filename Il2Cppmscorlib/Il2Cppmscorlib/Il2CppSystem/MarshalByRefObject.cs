using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting;

namespace Il2CppSystem
{
	// Token: 0x02000121 RID: 289
	[Serializable]
	public class MarshalByRefObject : Object
	{
		// Token: 0x060014CB RID: 5323 RVA: 0x00083638 File Offset: 0x00081838
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalByRefObject()
		{
			Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MarshalByRefObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr);
			MarshalByRefObject.NativeFieldInfoPtr__identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, "_identity");
			MarshalByRefObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666913);
			MarshalByRefObject.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666914);
			MarshalByRefObject.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666915);
			MarshalByRefObject.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666916);
			MarshalByRefObject.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666917);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000836E0 File Offset: 0x000818E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalByRefObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x0008371C File Offset: 0x0008191C
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x0008375C File Offset: 0x0008195C
		public unsafe ServerIdentity ObjectIdentity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 175618, RefRangeEnd = 175619, XrefRangeStart = 175613, XrefRangeEnd = 175618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 175624, RefRangeEnd = 175625, XrefRangeStart = 175619, XrefRangeEnd = 175624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000837A0 File Offset: 0x000819A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175625, XrefRangeEnd = 175630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByRefObject.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000837FC File Offset: 0x000819FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175630, XrefRangeEnd = 175635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object InitializeLifetimeService()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByRefObject.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000071FB File Offset: 0x000053FB
		public MarshalByRefObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x00083848 File Offset: 0x00081A48
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x00007204 File Offset: 0x00005404
		public unsafe Object _identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByRefObject.NativeFieldInfoPtr__identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByRefObject.NativeFieldInfoPtr__identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeFieldInfoPtr__identity;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0;
	}
}
