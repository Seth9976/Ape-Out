using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x020001FF RID: 511
	public class LockedObject<T> : Object
	{
		// Token: 0x060034F8 RID: 13560 RVA: 0x0010846C File Offset: 0x0010666C
		// Note: this type is marked as 'beforefieldinit'.
		static LockedObject()
		{
			Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "LockedObject`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr);
			LockedObject<T>.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr, "item");
			LockedObject<T>.NativeFieldInfoPtr_dDZACoecPJSvlJLQowwrDUVzZyf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr, "dDZACoecPJSvlJLQowwrDUVzZyf");
			LockedObject<T>.NativeFieldInfoPtr_abTYgeSoAAhdGgYetGPTvOGZisf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr, "abTYgeSoAAhdGgYetGPTvOGZisf");
			LockedObject<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr, 100676562);
			LockedObject<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr, 100676563);
			LockedObject<T>.NativeMethodInfoPtr_Lock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr, 100676564);
			LockedObject<T>.NativeMethodInfoPtr_Unlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr, 100676565);
			LockedObject<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr, 100676566);
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00108578 File Offset: 0x00106778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345930, XrefRangeEnd = 345933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockedObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedObject<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x001085B4 File Offset: 0x001067B4
		[CallerCount(0)]
		public unsafe LockedObject(Object lockObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockedObject<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lockObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedObject<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00108600 File Offset: 0x00106800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345933, XrefRangeEnd = 345934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedObject<T>.NativeMethodInfoPtr_Lock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00108634 File Offset: 0x00106834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345934, XrefRangeEnd = 345935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedObject<T>.NativeMethodInfoPtr_Unlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00108668 File Offset: 0x00106868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedObject<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000121E1 File Offset: 0x000103E1
		public LockedObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060034FF RID: 13567 RVA: 0x0010869C File Offset: 0x0010689C
		// (set) Token: 0x06003500 RID: 13568 RVA: 0x001086C4 File Offset: 0x001068C4
		public unsafe T item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockedObject<T>.NativeFieldInfoPtr_item);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockedObject<T>.NativeFieldInfoPtr_item);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003501 RID: 13569 RVA: 0x0010876C File Offset: 0x0010696C
		// (set) Token: 0x06003502 RID: 13570 RVA: 0x000121EA File Offset: 0x000103EA
		public unsafe Object dDZACoecPJSvlJLQowwrDUVzZyf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockedObject<T>.NativeFieldInfoPtr_dDZACoecPJSvlJLQowwrDUVzZyf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockedObject<T>.NativeFieldInfoPtr_dDZACoecPJSvlJLQowwrDUVzZyf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003503 RID: 13571 RVA: 0x0010879C File Offset: 0x0010699C
		// (set) Token: 0x06003504 RID: 13572 RVA: 0x00012209 File Offset: 0x00010409
		public unsafe bool abTYgeSoAAhdGgYetGPTvOGZisf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockedObject<T>.NativeFieldInfoPtr_abTYgeSoAAhdGgYetGPTvOGZisf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockedObject<T>.NativeFieldInfoPtr_abTYgeSoAAhdGgYetGPTvOGZisf)) = value;
			}
		}

		// Token: 0x04002D2A RID: 11562
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x04002D2B RID: 11563
		private static readonly IntPtr NativeFieldInfoPtr_dDZACoecPJSvlJLQowwrDUVzZyf;

		// Token: 0x04002D2C RID: 11564
		private static readonly IntPtr NativeFieldInfoPtr_abTYgeSoAAhdGgYetGPTvOGZisf;

		// Token: 0x04002D2D RID: 11565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D2E RID: 11566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04002D2F RID: 11567
		private static readonly IntPtr NativeMethodInfoPtr_Lock_Public_Void_0;

		// Token: 0x04002D30 RID: 11568
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Void_0;

		// Token: 0x04002D31 RID: 11569
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
	}
}
