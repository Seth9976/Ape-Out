using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000333 RID: 819
	[Serializable]
	public class ObjectIDGenerator : Object
	{
		// Token: 0x06003597 RID: 13719 RVA: 0x00107DC4 File Offset: 0x00105FC4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectIDGenerator()
		{
			Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectIDGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr);
			ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_currentCount");
			ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_currentSize");
			ObjectIDGenerator.NativeFieldInfoPtr_m_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_ids");
			ObjectIDGenerator.NativeFieldInfoPtr_m_objs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_objs");
			ObjectIDGenerator.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "sizes");
			ObjectIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671654);
			ObjectIDGenerator.NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671655);
			ObjectIDGenerator.NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671656);
			ObjectIDGenerator.NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671657);
			ObjectIDGenerator.NativeMethodInfoPtr_Rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671658);
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00107EBC File Offset: 0x001060BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213674, RefRangeEnd = 213676, XrefRangeStart = 213664, XrefRangeEnd = 213674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectIDGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00107EF8 File Offset: 0x001060F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213677, RefRangeEnd = 213680, XrefRangeStart = 213676, XrefRangeEnd = 213677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindElement(Object obj, out bool found)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &found;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x00107F54 File Offset: 0x00106154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213680, XrefRangeEnd = 213685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long GetId(Object obj, out bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectIDGenerator.NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00107FBC File Offset: 0x001061BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213685, XrefRangeEnd = 213686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long HasId(Object obj, out bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectIDGenerator.NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00108024 File Offset: 0x00106224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213707, RefRangeEnd = 213708, XrefRangeStart = 213686, XrefRangeEnd = 213707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr_Rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x00012EDF File Offset: 0x000110DF
		public ObjectIDGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x00108058 File Offset: 0x00106258
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x00012EE8 File Offset: 0x000110E8
		public unsafe int m_currentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount)) = value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x00108080 File Offset: 0x00106280
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x00012F03 File Offset: 0x00011103
		public unsafe int m_currentSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize)) = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x001080A8 File Offset: 0x001062A8
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x00012F1E File Offset: 0x0001111E
		public unsafe Il2CppStructArray<long> m_ids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_ids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x001080D8 File Offset: 0x001062D8
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x00012F3D File Offset: 0x0001113D
		public unsafe Il2CppReferenceArray<Object> m_objs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_objs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_objs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x00108108 File Offset: 0x00106308
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x00012F5C File Offset: 0x0001115C
		public unsafe static Il2CppStructArray<int> sizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectIDGenerator.NativeFieldInfoPtr_sizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectIDGenerator.NativeFieldInfoPtr_sizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D5B RID: 11611
		private static readonly IntPtr NativeFieldInfoPtr_m_currentCount;

		// Token: 0x04002D5C RID: 11612
		private static readonly IntPtr NativeFieldInfoPtr_m_currentSize;

		// Token: 0x04002D5D RID: 11613
		private static readonly IntPtr NativeFieldInfoPtr_m_ids;

		// Token: 0x04002D5E RID: 11614
		private static readonly IntPtr NativeFieldInfoPtr_m_objs;

		// Token: 0x04002D5F RID: 11615
		private static readonly IntPtr NativeFieldInfoPtr_sizes;

		// Token: 0x04002D60 RID: 11616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D61 RID: 11617
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0;

		// Token: 0x04002D62 RID: 11618
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0;

		// Token: 0x04002D63 RID: 11619
		private static readonly IntPtr NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0;

		// Token: 0x04002D64 RID: 11620
		private static readonly IntPtr NativeMethodInfoPtr_Rehash_Private_Void_0;
	}
}
