using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Services
{
	// Token: 0x020003A9 RID: 937
	public class TrackingServices : Object
	{
		// Token: 0x06003DD7 RID: 15831 RVA: 0x001248D8 File Offset: 0x00122AD8
		// Note: this type is marked as 'beforefieldinit'.
		static TrackingServices()
		{
			Il2CppClassPointerStore<TrackingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Services", "TrackingServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr);
			TrackingServices.NativeFieldInfoPtr__handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, "_handlers");
			TrackingServices.NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100672465);
			TrackingServices.NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100672466);
			TrackingServices.NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100672467);
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00124958 File Offset: 0x00122B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221416, XrefRangeEnd = 221445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyMarshaledObject(Object obj, ObjRef or)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x001249A0 File Offset: 0x00122BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221474, RefRangeEnd = 221475, XrefRangeStart = 221445, XrefRangeEnd = 221474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyUnmarshaledObject(Object obj, ObjRef or)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x001249E8 File Offset: 0x00122BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221475, XrefRangeEnd = 221504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyDisconnectedObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00017105 File Offset: 0x00015305
		public TrackingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x00124A20 File Offset: 0x00122C20
		// (set) Token: 0x06003DDD RID: 15837 RVA: 0x0001710E File Offset: 0x0001530E
		public unsafe static ArrayList _handlers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackingServices.NativeFieldInfoPtr__handlers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackingServices.NativeFieldInfoPtr__handlers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003334 RID: 13108
		private static readonly IntPtr NativeFieldInfoPtr__handlers;

		// Token: 0x04003335 RID: 13109
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0;

		// Token: 0x04003336 RID: 13110
		private static readonly IntPtr NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0;

		// Token: 0x04003337 RID: 13111
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0;
	}
}
