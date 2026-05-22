using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200047B RID: 1147
	public class IDictionaryEnumerator : Il2CppObjectBase
	{
		// Token: 0x060045D7 RID: 17879 RVA: 0x00141288 File Offset: 0x0013F488
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionaryEnumerator()
		{
			Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IDictionaryEnumerator");
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100673542);
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100673543);
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100673544);
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x001412EC File Offset: 0x0013F4EC
		public unsafe virtual Object Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x00141338 File Offset: 0x0013F538
		public unsafe virtual Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x00141384 File Offset: 0x0013F584
		public unsafe virtual DictionaryEntry Entry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DictionaryEntry(intPtr);
			}
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x0001A892 File Offset: 0x00018A92
		public IDictionaryEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038CD RID: 14541
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040038CE RID: 14542
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040038CF RID: 14543
		private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0;
	}
}
