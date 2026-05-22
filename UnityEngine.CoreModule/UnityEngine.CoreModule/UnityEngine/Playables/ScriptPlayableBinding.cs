using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000190 RID: 400
	public static class ScriptPlayableBinding : Object
	{
		// Token: 0x06001EBA RID: 7866 RVA: 0x00070F50 File Offset: 0x0006F150
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPlayableBinding()
		{
			Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayableBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr);
			ScriptPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr, 100666108);
			ScriptPlayableBinding.NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr, 100666109);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00070FA8 File Offset: 0x0006F1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504390, RefRangeEnd = 504391, XrefRangeStart = 504381, XrefRangeEnd = 504390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableBinding Create(string name, Object key, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PlayableBinding(intPtr);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00071008 File Offset: 0x0006F208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504391, XrefRangeEnd = 504392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableBinding.NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00010081 File Offset: 0x0000E281
		public ScriptPlayableBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0;
	}
}
