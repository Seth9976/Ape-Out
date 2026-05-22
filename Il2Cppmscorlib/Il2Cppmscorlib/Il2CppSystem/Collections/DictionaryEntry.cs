using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200046D RID: 1133
	[Serializable]
	public sealed class DictionaryEntry : ValueType
	{
		// Token: 0x060044CE RID: 17614 RVA: 0x0013CA50 File Offset: 0x0013AC50
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryEntry()
		{
			Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "DictionaryEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr);
			DictionaryEntry.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, "_key");
			DictionaryEntry.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, "_value");
			DictionaryEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100673301);
			DictionaryEntry.NativeMethodInfoPtr_get_Key_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100673302);
			DictionaryEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100673303);
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x0013CAE4 File Offset: 0x0013ACE4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 5426, RefRangeEnd = 5459, XrefRangeStart = 5426, XrefRangeEnd = 5459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionaryEntry(Object key, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x0013CB48 File Offset: 0x0013AD48
		public unsafe Object Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr_get_Key_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x060044D1 RID: 17617 RVA: 0x0013CB8C File Offset: 0x0013AD8C
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x0001A412 File Offset: 0x00018612
		public DictionaryEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x0001A41B File Offset: 0x0001861B
		public DictionaryEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr))
		{
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x0013CBD0 File Offset: 0x0013ADD0
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x0001A42D File Offset: 0x0001862D
		public unsafe Object _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x0013CC00 File Offset: 0x0013AE00
		// (set) Token: 0x060044D7 RID: 17623 RVA: 0x0001A44C File Offset: 0x0001864C
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003808 RID: 14344
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x04003809 RID: 14345
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x0400380A RID: 14346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x0400380B RID: 14347
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_Object_0;

		// Token: 0x0400380C RID: 14348
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;
	}
}
