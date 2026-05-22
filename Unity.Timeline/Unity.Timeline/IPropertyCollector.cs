using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004A RID: 74
	public class IPropertyCollector : Il2CppObjectBase
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x00017CC0 File Offset: 0x00015EC0
		// Note: this type is marked as 'beforefieldinit'.
		static IPropertyCollector()
		{
			Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IPropertyCollector");
			IPropertyCollector.NativeMethodInfoPtr_PushActiveGameObject_Public_Abstract_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664104);
			IPropertyCollector.NativeMethodInfoPtr_PopActiveGameObject_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664105);
			IPropertyCollector.NativeMethodInfoPtr_AddFromClip_Public_Abstract_Virtual_New_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664106);
			IPropertyCollector.NativeMethodInfoPtr_AddFromClips_Public_Abstract_Virtual_New_Void_IEnumerable_1_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664107);
			IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664108);
			IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664109);
			IPropertyCollector.NativeMethodInfoPtr_AddFromClip_Public_Abstract_Virtual_New_Void_GameObject_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664110);
			IPropertyCollector.NativeMethodInfoPtr_AddFromClips_Public_Abstract_Virtual_New_Void_GameObject_IEnumerable_1_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664111);
			IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664112);
			IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664113);
			IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_Component_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664114);
			IPropertyCollector.NativeMethodInfoPtr_AddFromComponent_Public_Abstract_Virtual_New_Void_GameObject_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664115);
			IPropertyCollector.NativeMethodInfoPtr_AddObjectProperties_Public_Abstract_Virtual_New_Void_Object_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr, 100664116);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00017DEC File Offset: 0x00015FEC
		[CallerCount(0)]
		public unsafe virtual void PushActiveGameObject(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_PushActiveGameObject_Public_Abstract_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00017E3C File Offset: 0x0001603C
		[CallerCount(0)]
		public unsafe virtual void PopActiveGameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_PopActiveGameObject_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00017E78 File Offset: 0x00016078
		[CallerCount(0)]
		public unsafe virtual void AddFromClip(AnimationClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddFromClip_Public_Abstract_Virtual_New_Void_AnimationClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00017EC8 File Offset: 0x000160C8
		[CallerCount(0)]
		public unsafe virtual void AddFromClips(IEnumerable<AnimationClip> clips)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clips);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddFromClips_Public_Abstract_Virtual_New_Void_IEnumerable_1_AnimationClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00017F18 File Offset: 0x00016118
		[CallerCount(0)]
		public unsafe virtual void AddFromName<T>(string name) where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.MethodInfoStoreGeneric_AddFromName_Public_Abstract_Virtual_New_Void_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00017F68 File Offset: 0x00016168
		[CallerCount(0)]
		public unsafe virtual void AddFromName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00017FB8 File Offset: 0x000161B8
		[CallerCount(0)]
		public unsafe virtual void AddFromClip(GameObject obj, AnimationClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddFromClip_Public_Abstract_Virtual_New_Void_GameObject_AnimationClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00018018 File Offset: 0x00016218
		[CallerCount(0)]
		public unsafe virtual void AddFromClips(GameObject obj, IEnumerable<AnimationClip> clips)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clips);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddFromClips_Public_Abstract_Virtual_New_Void_GameObject_IEnumerable_1_AnimationClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00018078 File Offset: 0x00016278
		[CallerCount(0)]
		public unsafe virtual void AddFromName<T>(GameObject obj, string name) where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.MethodInfoStoreGeneric_AddFromName_Public_Abstract_Virtual_New_Void_GameObject_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000180D8 File Offset: 0x000162D8
		[CallerCount(0)]
		public unsafe virtual void AddFromName(GameObject obj, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_GameObject_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00018138 File Offset: 0x00016338
		[CallerCount(0)]
		public unsafe virtual void AddFromName(Component component, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_Component_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00018198 File Offset: 0x00016398
		[CallerCount(0)]
		public unsafe virtual void AddFromComponent(GameObject obj, Component component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddFromComponent_Public_Abstract_Virtual_New_Void_GameObject_Component_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000181F8 File Offset: 0x000163F8
		[CallerCount(0)]
		public unsafe virtual void AddObjectProperties(Object obj, AnimationClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyCollector.NativeMethodInfoPtr_AddObjectProperties_Public_Abstract_Virtual_New_Void_Object_AnimationClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00003A5C File Offset: 0x00001C5C
		public IPropertyCollector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_PushActiveGameObject_Public_Abstract_Virtual_New_Void_GameObject_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_PopActiveGameObject_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_AddFromClip_Public_Abstract_Virtual_New_Void_AnimationClip_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_AddFromClips_Public_Abstract_Virtual_New_Void_IEnumerable_1_AnimationClip_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_AddFromClip_Public_Abstract_Virtual_New_Void_GameObject_AnimationClip_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_AddFromClips_Public_Abstract_Virtual_New_Void_GameObject_IEnumerable_1_AnimationClip_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_GameObject_String_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_GameObject_String_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_Component_String_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_AddFromComponent_Public_Abstract_Virtual_New_Void_GameObject_Component_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_AddObjectProperties_Public_Abstract_Virtual_New_Void_Object_AnimationClip_0;

		// Token: 0x02000079 RID: 121
		private sealed class MethodInfoStoreGeneric_AddFromName_Public_Abstract_Virtual_New_Void_String_0<T>
		{
			// Token: 0x040004C0 RID: 1216
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_String_0, Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007A RID: 122
		private sealed class MethodInfoStoreGeneric_AddFromName_Public_Abstract_Virtual_New_Void_GameObject_String_0<T>
		{
			// Token: 0x040004C1 RID: 1217
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IPropertyCollector.NativeMethodInfoPtr_AddFromName_Public_Abstract_Virtual_New_Void_GameObject_String_0, Il2CppClassPointerStore<IPropertyCollector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
