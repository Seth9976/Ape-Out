using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000406 RID: 1030
	public class RemotingSurrogateSelector : Object
	{
		// Token: 0x0600420D RID: 16909 RVA: 0x00133910 File Offset: 0x00131B10
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingSurrogateSelector()
		{
			Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "RemotingSurrogateSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr);
			RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "s_cachedTypeObjRef");
			RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_objRefSurrogate");
			RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_objRemotingSurrogate");
			RemotingSurrogateSelector.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_next");
			RemotingSurrogateSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, 100672982);
			RemotingSurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, 100672983);
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x001339B8 File Offset: 0x00131BB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingSurrogateSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingSurrogateSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x001339F4 File Offset: 0x00131BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225554, XrefRangeEnd = 225560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingSurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ssout = ((intPtr4 == 0) ? null : new ISurrogateSelector(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr5) : null;
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x00018E10 File Offset: 0x00017010
		public RemotingSurrogateSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x00133A8C File Offset: 0x00131C8C
		// (set) Token: 0x06004212 RID: 16914 RVA: 0x00018E19 File Offset: 0x00017019
		public unsafe static Type s_cachedTypeObjRef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x00133AB4 File Offset: 0x00131CB4
		// (set) Token: 0x06004214 RID: 16916 RVA: 0x00018E2B File Offset: 0x0001702B
		public unsafe static ObjRefSurrogate _objRefSurrogate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRefSurrogate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06004215 RID: 16917 RVA: 0x00133ADC File Offset: 0x00131CDC
		// (set) Token: 0x06004216 RID: 16918 RVA: 0x00018E3D File Offset: 0x0001703D
		public unsafe static RemotingSurrogate _objRemotingSurrogate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemotingSurrogate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x00133B04 File Offset: 0x00131D04
		// (set) Token: 0x06004218 RID: 16920 RVA: 0x00018E4F File Offset: 0x0001704F
		public unsafe ISurrogateSelector _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingSurrogateSelector.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingSurrogateSelector.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035F2 RID: 13810
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedTypeObjRef;

		// Token: 0x040035F3 RID: 13811
		private static readonly IntPtr NativeFieldInfoPtr__objRefSurrogate;

		// Token: 0x040035F4 RID: 13812
		private static readonly IntPtr NativeFieldInfoPtr__objRemotingSurrogate;

		// Token: 0x040035F5 RID: 13813
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x040035F6 RID: 13814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035F7 RID: 13815
		private static readonly IntPtr NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0;
	}
}
