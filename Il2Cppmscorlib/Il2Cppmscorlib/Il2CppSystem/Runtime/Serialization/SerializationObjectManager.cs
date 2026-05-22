using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034C RID: 844
	public sealed class SerializationObjectManager : Object
	{
		// Token: 0x06003738 RID: 14136 RVA: 0x0010E1D8 File Offset: 0x0010C3D8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationObjectManager()
		{
			Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationObjectManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr);
			SerializationObjectManager.NativeFieldInfoPtr_m_objectSeenTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "m_objectSeenTable");
			SerializationObjectManager.NativeFieldInfoPtr_m_onSerializedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "m_onSerializedHandler");
			SerializationObjectManager.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "m_context");
			SerializationObjectManager.NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671855);
			SerializationObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671856);
			SerializationObjectManager.NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671857);
			SerializationObjectManager.NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671858);
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x0010E294 File Offset: 0x0010C494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215641, XrefRangeEnd = 215648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationObjectManager(StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x0010E2E4 File Offset: 0x0010C4E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215663, RefRangeEnd = 215664, XrefRangeStart = 215648, XrefRangeEnd = 215663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x0010E328 File Offset: 0x0010C528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215664, XrefRangeEnd = 215665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseOnSerializedEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x0010E35C File Offset: 0x0010C55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215665, XrefRangeEnd = 215671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOnSerialized(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x00013A50 File Offset: 0x00011C50
		public SerializationObjectManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x0010E3A0 File Offset: 0x0010C5A0
		// (set) Token: 0x0600373F RID: 14143 RVA: 0x00013A59 File Offset: 0x00011C59
		public unsafe Hashtable m_objectSeenTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_objectSeenTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_objectSeenTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06003740 RID: 14144 RVA: 0x0010E3D0 File Offset: 0x0010C5D0
		// (set) Token: 0x06003741 RID: 14145 RVA: 0x00013A78 File Offset: 0x00011C78
		public unsafe SerializationEventHandler m_onSerializedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_onSerializedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_onSerializedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x0010E400 File Offset: 0x0010C600
		// (set) Token: 0x06003743 RID: 14147 RVA: 0x00013A97 File Offset: 0x00011C97
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeFieldInfoPtr_m_objectSeenTable;

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeFieldInfoPtr_m_onSerializedHandler;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0;

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0;
	}
}
